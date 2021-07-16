using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShopFinal
{
    public partial class frmGeneral : Form
    {
        private DBSQL mySQL;
        Product[] products;
        Supplier[] suppliers;
        Customer[] customers;

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
        private void refreshProducts()
        {
            products = mySQL.GetProductsData();
        }
        private void refreshSuppliers()
        {
            suppliers = mySQL.GetSuppliersData();
        }
        private void refreshCustomers()
        {
            customers = mySQL.GetCustomersData();
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
            refreshProducts();
            destList.Items.Clear();
            fillListBox(destList, products, "Name", "SupplierId");
        }

        //get data from db and loading the new data to the selected ListBox
        private void LoadSuppliersToList(ListBox destList)
        {
            refreshSuppliers();
            destList.Items.Clear();
            fillListBox(destList, suppliers, "Name", "Id");
        }

        //get data from db and loading the new data to the selected ComboBox
        private void LoadSuppliersToCbo(ComboBox destList)
        {
            refreshSuppliers();
            destList.Items.Clear();
            fillCboList(destList, suppliers, "Name", "Id");
        }

        // Loads customers to Listview in Customers tab
        private void LoadCustomersToList(ListView destList)
        {
            refreshCustomers();
            //lstvCustomers.Items.Clear();
            destList.Items.Clear();
            foreach (Customer customer in customers)
            {
                string[] row = { customer.Id.ToString(), customer.FirstName, customer.LastName };
                ListViewItem itm = new ListViewItem(row);
                destList.Items.Add(itm);
            }
        }
        //Save edited customer to db and refresh the list
        private void ucEditCustomer_OnSaveButtonClickEvent(object sender, EventArgs e)
        {

            ucEditCustomer.RefreshData();
            if (mySQL.UpdateCustomer(ucEditCustomer.Customer)) // if query passed
            {
                LoadCustomersToList(lstvCustomers);
                ucEditCustomer.Clear();
            }

        }

        //Updating the product data to edit in Products tab
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProd = lstProducts.SelectedItem as Product;
            if (selectedProd != null)
            {
                cboEditProd.SelectedIndex = Array.FindIndex(suppliers, supplier => supplier.Id == selectedProd.SupplierId);
                txtEditProd.Text = selectedProd.Name;
            }
        }

        //updating the data according the current tab
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex == 0)
            {
                LoadProductsToList(lstProducts);
                LoadSuppliersToCbo(cboAddProd);
                LoadSuppliersToCbo(cboEditProd);
            }
            else
            if (tabMain.SelectedIndex == 1)
            {
                lstvProducts.Columns.Clear();
                lstvProducts.Columns.Add("ID");
                lstvProducts.Columns.Add("Name", 150);
                lstvProducts.Columns.Add("SupplierId");
                lstvProducts.View = View.Details;
                lstvProducts.GridLines = true;
                lstvProducts.FullRowSelect = true;
                LoadSuppliersToList(lstSuppliers);
            }
            else
            if (tabMain.SelectedIndex == 2)
            {
                lstvCustomers.Columns.Clear();
                lstvCustomers.Columns.Add("ID");
                lstvCustomers.Columns.Add("First Name", 120);
                lstvCustomers.Columns.Add("Last Name", 120);
                lstvCustomers.View = View.Details;
                lstvCustomers.GridLines = true;
                lstvCustomers.FullRowSelect = true;
                LoadCustomersToList(lstvCustomers);
            }
        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier selectedSupp = lstSuppliers.SelectedItem as Supplier;
            refreshProducts();
            lstvProducts.Items.Clear();
            if (selectedSupp != null)
            {

                foreach (Product product in products)
                {
                    if (product.SupplierId == selectedSupp.Id)
                    {
                        string[] row = { product.Id.ToString(), product.Name, product.SupplierId.ToString() };
                        ListViewItem itm = new ListViewItem(row);
                        lstvProducts.Items.Add(itm);
                    }
                }
                ucEditSupplier.Supplier = selectedSupp;
            }
        }

        private void lstvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Customer customer in customers)
            {
                if (customer.Id == Convert.ToInt32(lstvCustomers.FocusedItem.Text))
                {
                    ucEditCustomer.Customer = customer;
                    break;
                }
            }

        }


        private void btnEditProd_Click(object sender, EventArgs e)
        {
            Product edtPrd = new Product();
            edtPrd.Name = txtEditProd.Text;
            edtPrd.SupplierId = ((Supplier)cboEditProd.SelectedItem).Id;
            edtPrd.Id = ((Product)lstProducts.SelectedItem).Id;
            if (mySQL.UpdateProduct(edtPrd))
            {
                LoadProductsToList(lstProducts);
                clearEditProduct();
            }

        }

        private void btnRemoveProd_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                int selectedId = ((Product)lstProducts.SelectedItem).Id;
                if (MessageHandler.Show("Delete Product", "Are you sure to delete this product?") == DialogResult.OK)
                    if (mySQL.DeleteProduct(selectedId))
                    {
                        LoadProductsToList(lstProducts);
                        clearEditProduct();
                    }
            }
        }




        private void clearEditProduct()
        {
            cboEditProd.SelectedItem = null;
            txtEditProd.Text = "";
        }

        private void clearAddProduct()
        {
            cboAddProd.SelectedItem = null;
            txtAddProd.Text = "";
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            Product addPrd = new Product();
            addPrd.Name = txtAddProd.Text;
            addPrd.SupplierId = ((Supplier)cboAddProd.SelectedItem).Id;

            if (mySQL.InsertProduct(addPrd))
            {
                LoadProductsToList(lstProducts);
                clearAddProduct();
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
            MessageDialog messageDialog = new MessageDialog();
            if (lstSuppliers.SelectedItem != null)
                if (MessageHandler.Show("Delete", "Are you sure?") == DialogResult.OK)
                {
                    if (mySQL.RemoveSupplier(((Supplier)lstSuppliers.SelectedItem).Id))
                    {
                        LoadSuppliersToList(lstSuppliers);
                        ucEditSupplier.Clear();
                    }
                }

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

            if (mySQL.UpdateSupplier(ucEditSupplier.Supplier))
            {
                LoadSuppliersToList(lstSuppliers);
                ucEditSupplier.Clear();
            }
        }

        private void lstvCustomers_MouseLeave(object sender, EventArgs e)
        {
            lstvCustomers.SelectedItems.Clear();
        }

        private void ucAddCustomer_OnSaveButtonClickEvent(object sender, EventArgs e)
        {
            ucAddCustomer.RefreshData();
            if (mySQL.InsertCustomer(ucAddCustomer.Customer))
            {
                LoadCustomersToList(lstvCustomers);
                ucAddCustomer.Clear();
            }
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            Customer selected = ucEditCustomer.Customer;
            if (selected.Id != -1)
                if (MessageHandler.Show("Delete Customer", $"Are you sure to delete?\n{selected.FirstName} {selected.LastName}") == DialogResult.OK)
                {
                    if (mySQL.RemoveCustomer(selected.Id))
                    {
                        LoadCustomersToList(lstvCustomers);
                        //ucEditCustomer.Customer.Clear();
                        ucEditCustomer.Clear();
                    }
                }
        }
    }
}
