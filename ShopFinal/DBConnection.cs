using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFinal
{
    public class DBConnection
    {
        protected static string baseDatabaseName = string.Empty;
        protected static string baseUserName = string.Empty;
        protected static string basePassword = string.Empty;

        protected static string connString = string.Empty;

        private static DBConnection _instance = null;

        private static MySqlConnection connection = null;


        public static DBConnection Instance()
        {
            bool result = true;

            if (_instance == null)
            {
                _instance = new DBConnection(); //Creating instance of DB connection

                result = !string.IsNullOrEmpty(baseDatabaseName);
            }

            if (result)
            {
                connString = string.Format($"Server=localhost; database={baseDatabaseName}; UID={baseUserName}; password={basePassword}");
                connection = new MySqlConnection(connString);

            }
            return _instance;
        }

        public bool Connect()
        {
            bool result = true;

            try
            {
                connection.Open(); // Opens a connection with the sql server
            }
            catch (Exception e)
            {
                result = false; // if could not create a connection, set result = false 
            }


            return result; // returns the result of the connect function
        }
        public void Close()
        {
            connection.Close(); // closing the connection
        }
        protected bool ExecuteSimpleQuery(MySqlCommand command)
        {
            bool result = true;

            lock (connection) // locking the connection to avoid parallel access
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        result = false;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
            return result;
        }

        protected int ExecuteScalarIntQuery(MySqlCommand command)
        {
            int result = -1;

            lock (connection) // locking the connection to avoid parallel access
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        result = (int)command.ExecuteScalar();

                    }
                    catch (Exception e)
                    {
                        result = -1;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }

            return result;
        }

        protected DataSet GetMultipleQuery(MySqlCommand command)
        {

            DataSet dataset = new DataSet();
            lock (connection)
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = command;
                        adapter.Fill(dataset);
                    }
                    catch (Exception e)
                    {
                        dataset = null;
                    }
                    finally
                    {
                        Close();
                    }
                }
            }
            return dataset;
        }



    }
}
