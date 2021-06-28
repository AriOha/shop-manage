using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopFinal
{
    public partial class frmGeneral : Form
    {
        private DBSQL mySQL;
        public frmGeneral()
        {
            InitializeComponent();
            //Set the credentials for the db
            DBSQL.DatabaseName = "shop";
            DBSQL.UserName = "root";
            DBSQL.Password = "secret";
            mySQL = DBSQL.Instance;

            fillProducts();
        }


        private void fillProducts()
        {
            Product[] products = mySQL.GetProductsData();
            lstProducts.Items.Clear();

            for (int i = 0; i < products.Length; i++)
                lstProducts.Items.Add(products[i].Name);

        }

    }
}
