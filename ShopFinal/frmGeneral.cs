using System;
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

            fillProducts();
            fillSuppliers();
        }


        private void fillProducts()
        {
            products = mySQL.GetProductsData();
            lstProducts.Items.Clear();

            for (int i = 0; i < products.Length; i++)
                lstProducts.Items.Add(products[i].Name);

        }

        private void fillSuppliers()
        {
            suppliers = mySQL.GetSuppliersData();
            cboEditSupp.Items.Clear();
            cboAddProd.Items.Clear();

            for (int i = 0; i < suppliers.Length; i++)
            {
                cboEditSupp.Items.Add(suppliers[i].Name);
                cboAddProd.Items.Add(suppliers[i].Name);

            }
        }



        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = products[lstProducts.SelectedIndex];
            int i = Array.FindIndex(suppliers, supplier => supplier.Id == p.SupplierId);
            Supplier s = suppliers[i];
            cboEditSupp.SelectedIndex = cboEditSupp.Items.IndexOf(s.Name);
            txtEditProd.Text = p.Name;

        }
    }
}
