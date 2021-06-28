using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    public class DBSQL : DBConnection
    {
        private static DBSQL instance;

        private DBSQL()
        {
            baseDatabaseName = "shop";
            baseUserName = "root";
            basePassword = "secret";
        }

        public static DBSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    DBConnection connection = DBConnection.Instance();
                    instance = new DBSQL();
                }
                return instance;
            }
        }

        public static string DatabaseName
        {
            set
            {
                if (value != string.Empty)
                {
                    baseDatabaseName = value;
                }
            }
            get
            {
                return baseDatabaseName;
            }
        }

        public static string UserName
        {
            set
            {
                if (value != string.Empty)
                {
                    baseUserName = value;
                }
            }
            get
            {
                return baseUserName;
            }
        }
        public static string Password
        {
            set
            {
                if (value != string.Empty)
                {
                    basePassword = value;
                }
            }
            get
            {
                return basePassword;
            }
        }

        //####################Products####################
        public int GetProductsMaxId()
        {
            int result;
            string cmdStr = "SELECT Max(productId) FROM products";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        public void InsertProduct(Product Item)
        {
            string cmdStr = "INSERT INTO products(name,supplierId) VALUES(@name,@supplierId)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", Item.Name);
                command.Parameters.AddWithValue("@supplierId", Item.SupplierId);

                base.ExecuteSimpleQuery(command);
            }

        }

        public Product[] GetProductsData()
        {
            DataSet ds = new DataSet(); //creating dataset to get the result from db into ds tables
            Product[] products = null;
            string cmdStr = "SELECT * FROM products";

            using (MySqlCommand command = new MySqlCommand(cmdStr)) //free the MySqlCommand after finishing the query
            {
                ds = GetMultipleQuery(command); //returns data of cities
            }
            DataTable dt = new DataTable(); // Creating data table to be as reference to ds to get the result table from the query
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            if (dt.Rows.Count > 0) // if received data from the database
            {
                products = new Product[dt.Rows.Count];
                for (int i = 0; i < products.Length; i++)
                {
                    products[i] = new Product();
                    products[i].Id = Convert.ToInt64(dt.Rows[i][0]); //product id stored at column 0
                    products[i].Name = dt.Rows[i][1].ToString();// product name stored at column 2
                    products[i].SupplierId = Convert.ToInt64(dt.Rows[i][2]); //supplier id stored at column 1
                }
            }
            return products;
        }
