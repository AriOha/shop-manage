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


        }


        private void fillProducts(ListBox list, string key, string value)
        {
            products = mySQL.GetProductsData();
            list.Items.Clear();

            foreach (Product product in products)
                list.Items.Add(product);
            list.ValueMember = value; // The value of the selected item(it's supplier id)
            list.DisplayMember = key; // the value that will displayed at the list(product name)
        }
        private void fillSuppliersLst(ListBox list, string key, string value)
        {
            suppliers = mySQL.GetSuppliersData();
            list.Items.Clear();

            for (int i = 0; i < suppliers.Length; i++)
                list.Items.Add(suppliers[i]);
            list.ValueMember = value; // The value of the selected item(it's supplier id)
            list.DisplayMember = key; // the value that will displayed at the list(product name)
        }

        private void fillSuppliersCbo(ComboBox list, string key, string value)
        {
            //Dictionary cboSource = new Dictionary();
            suppliers = mySQL.GetSuppliersData();
            //cboEditSupp.Items.Clear();
            list.Items.Clear();

            for (int i = 0; i < suppliers.Length; i++)
            {
                //cboEditSupp.Items.Add($"{suppliers[i].Name}({suppliers[i].Id}");
                //cboEditSupp.Items.Add(suppliers[i]);
                list.Items.Add(suppliers[i]);
            }
            //cboEditSupp.DataSource = new BindingSource(cboSource, null);
            list.DisplayMember = key;// the value that will displayed at the list(supplier name)
            list.ValueMember = value; // the value of the selected item at the list(supplier id)
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
                fillProducts(lstProducts, "Name", "SupplierId");
                fillSuppliersCbo(cboAddProd, "Id", "Name");
                fillSuppliersCbo(cboEditSupp, "Id", "Name");
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
                fillSuppliersLst(lstSuppliers, "Name", "Id");
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
        }
    }
}
