using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShopFinal
{
    public partial class frmGeneral : Form
    {
        private DBSQL mySQL;
        Product[] products;
        Supplier[] suppliers;

        public frmGeneral()
        {
            InitializeComponent();
            //Set the credentials for the db
            DBSQL.DatabaseName = "shop";
            DBSQL.UserName = "root";
            DBSQL.Password = "secret";
            mySQL = DBSQL.Instance;
            tabMain.SelectedIndex = 0;

        }



        //function get list of objects and insert them to the given ListBox binding key and value
        private void fillListBox<T>(ListBox destList, IEnumerable<T> sourceArr, string key, string value)
        {
            foreach (T item in sourceArr)
                destList.Items.Add(item);
            destList.ValueMember = value; // The value of the selected item
            destList.DisplayMember = key; // the value that will displayed at the list(name)
        }
        //function get list of objects and insert them to the given ComboBox binding key and value
        private void fillCboList<T>(ComboBox destList, IEnumerable<T> sourceArr, string key, string value)
        {
            foreach (T item in sourceArr)
                destList.Items.Add(item);
            destList.ValueMember = value; // the value of the selected item at the list(supplier id)
            destList.DisplayMember = key;// the value that will displayed at the list(supplier name)
        }

        private void LoadProductsToList(ListBox destList)
        {
            destList.Items.Clear();
            products = mySQL.GetProductsData();
            fillListBox(destList, products, "Name", "SupplierId");
        }

        //get data from db and loading the new data to the selected ListBox
        private void LoadSuppliersToList(ListBox destList)
        {
            destList.Items.Clear();
            suppliers = mySQL.GetSuppliersData();
            fillListBox(destList, suppliers, "Name", "Id");
        }

        //get data from db and loading the new data to the selected ComboBox
        private void LoadSuppliersToCbo(ComboBox destList)
        {
            destList.Items.Clear();
            suppliers = mySQL.GetSuppliersData();
            fillCboList(destList, suppliers, "Name", "Id");
        }


        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Product p = products[lstProducts.SelectedIndex];
            Product selectedProd = lstProducts.SelectedItem as Product;
            //cboEditSupp.SelectedItem = ;
            cboEditSupp.SelectedIndex = Array.FindIndex(suppliers, supplier => supplier.Id == selectedProd.SupplierId);
            txtEditProd.Text = selectedProd.Name;

        }


        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 0)
            {
                LoadProductsToList(lstProducts);
                LoadSuppliersToCbo(cboAddProd);
                LoadSuppliersToCbo(cboEditSupp);
            }
            else
            if (tabMain.SelectedIndex == 1)
            {
                lstvProducts.Columns.Clear();
                lstvProducts.Columns.Add("ID", 100);
                lstvProducts.Columns.Add("Name", 100);
                lstvProducts.Columns.Add("SupplierId", 100);
                lstvProducts.View = View.Details;
                lstvProducts.GridLines = true;
                lstvProducts.FullRowSelect = true;
                LoadSuppliersToList(lstSuppliers);
            }
        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier selectedSupp = lstSuppliers.SelectedItem as Supplier;
            lstvProducts.Items.Clear();
            foreach (Product product in products)
            {
                if (product.SupplierId == selectedSupp.Id)
                {
                    string[] row = { product.Id.ToString(), product.Name, product.SupplierId.ToString() };
                    ListViewItem itm = new ListViewItem(row);
                    lstvProducts.Items.Add(itm);
                }
            }
            fillEditSupplier(selectedSupp);
        }

        private void fillEditSupplier(Supplier supplier)
        {
            txtEditSupp.Text = supplier.Name;
            txtEditAddress.Text = supplier.Address;
            txtEditPhone.Text = supplier.Phone;
            txtEditEmail.Text = supplier.Email;
        }


        private void btnEditProd_Click(object sender, EventArgs e)
        {

            Product edtPrd = new Product();
            edtPrd.Name = txtEditProd.Text;
            edtPrd.SupplierId = ((Supplier)cboEditSupp.SelectedItem).Id;
            edtPrd.Id = ((Product)lstProducts.SelectedItem).Id;
            if (mySQL.UpdateProduct(edtPrd))
            {
                LoadProductsToList(lstProducts);
            }

        }

        private void ucAddSupplier_onSaveButtonClickEvent(object sender, EventArgs e)
        {
            ucAddSupplier.RefreshData();
            if (mySQL.InsertSupplier(ucAddSupplier.Supplier))
            {
                LoadSuppliersToList(lstSuppliers);
                ucAddSupplier.Clear();
            }

        }

        private void ucEditSupplier_OnSaveButtonClickEvent(object sender, EventArgs e)
        {
            ucEditSupplier.RefreshData();
            if (mySQL.UpdateSupplier(ucEditSupplier.Supplier))
            {
                LoadSuppliersToList(lstSuppliers);
                ucEditSupplier.Clear();
            }
        }


        private void ucEditSupplier_OnClearButtonClickEvent(object sender, EventArgs e)
        {
            lstSuppliers.SelectedItem = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (frmPrompt confirmDelete = new frmPrompt())
            {
                //if (confirmDelete.ShowDialog() == DialogResult.OK)
                //{
                //    this.Text = "Cool";
                //}
                btnRemove.Text= confirmDelete.ShowDialog().ToString();
            }
            //int res = Prompt.ShowDialog("Hello","Dear");
        }
    }
}
