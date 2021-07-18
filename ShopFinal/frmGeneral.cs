using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ShopFinal
{
    public partial class frmGeneral : Form
    {
        private DBSQL mySQL;
        Product[] products;
        Supplier[] suppliers;
        Customer[] customers;
        Order[] orders;

        public frmGeneral()
        {
            InitializeComponent();
            //Set the credentials for the db
            DBSQL.DatabaseName = "shop";
            DBSQL.UserName = "root";
            DBSQL.Password = "secret";
            mySQL = DBSQL.Instance;
            lblName1.Text = "Ariel Ohayon";
            lblName2.Text = "Boris Sverdlov";
        }


        //updating the data according the current tab
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 1:
                    //Products Tab
                    LoadProductsToList(lstProducts);
                    LoadSuppliersToCbo(cboAddProd);
                    LoadSuppliersToCbo(cboEditProd);
                    break;
                case 2:
                    //Suppliers Tab
                    lstvProducts.Columns.Clear();
                    lstvProducts.Columns.Add("ID");
                    lstvProducts.Columns.Add("Name", 150);
                    lstvProducts.Columns.Add("SupplierId");
                    lstvProducts.View = View.Details;
                    lstvProducts.GridLines = true;
                    lstvProducts.FullRowSelect = true;
                    LoadSuppliersToList(lstSuppliers);
                    break;
                case 3:
                    //Customers Tab
                    lstvCustomers.Columns.Clear();
                    lstvCustomers.Columns.Add("ID");
                    lstvCustomers.Columns.Add("First Name", 120);
                    lstvCustomers.Columns.Add("Last Name", 120);
                    lstvCustomers.View = View.Details;
                    lstvCustomers.GridLines = true;
                    lstvCustomers.FullRowSelect = true;
                    LoadCustomersToListView(lstvCustomers);
                    break;
                case 4:
                    //New Order Tab
                    LoadProductsToList(lstOrderProducts);
                    LoadCustomersToList(lstNewOrderCustomers);
                    lstOrderSelected.ValueMember = "SupplierId"; // The value of the selected item
                    lstOrderSelected.DisplayMember = "Name"; // the value that will displayed at the list(name)
                    lstOrderSelected.Items.Clear();
                    break;
                case 5:
                    //Display Orders Tab
                    lstvOrders.Columns.Clear();
                    lstvOrderProducts.Columns.Clear();
                    lstvOrders.Columns.Add("ID", 40);
                    lstvOrders.Columns.Add("Date", 70);
                    lstvOrders.Columns.Add("Time", 60);
                    lstvOrders.View = View.Details;
                    lstvOrders.GridLines = true;
                    lstvOrders.FullRowSelect = true;
                    lstvOrderProducts.Columns.Add("Product ID", 70);
                    lstvOrderProducts.Columns.Add("Product Name", 140);
                    lstvOrderProducts.Columns.Add("Supplier ID", 70);
                    lstvOrderProducts.View = View.Details;
                    lstvOrderProducts.FullRowSelect = true;
                    LoadCustomersToList(lstDisplayOrderCustomers);
                    lstvOrders.Items.Clear();
                    lstvOrderProducts.Items.Clear();
                    break;
                case 6:
                    //Reports Tab
                    break;
                default:
                    break;
            }

        }


        /// <summary>
        /// Getting data from db to Products list
        /// </summary>
        private void refreshProducts()
        {
            products = mySQL.GetProductsData();
        }

        /// <summary>
        /// Getting data from db to Suppliers list
        /// </summary>
        private void refreshSuppliers()
        {
            suppliers = mySQL.GetSuppliersData();
        }

        /// <summary>
        /// Getting data from db to Customers list
        /// </summary>
        private void refreshCustomers()
        {
            customers = mySQL.GetCustomersData();
        }

        /// <summary>
        /// Getting data from db to Orders list
        /// </summary>
        private void refreshOrders()
        {
            orders = mySQL.GetOrdersData();
        }



        /// <summary>
        ///function get list of objects and insert them to the given ListBox binding key and value
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="destList">ListBox list to add to</param>
        /// <param name="sourceArr">array of data(key-value)) to insert to the list box</param>
        /// <param name="key">The data to display(What user see)</param>
        /// <param name="value">the data that will be used on the item</param>
        private void fillListBox<T>(ListBox destList, IEnumerable<T> sourceArr, string key, string value)
        {
            foreach (T item in sourceArr)
                destList.Items.Add(item);
            destList.ValueMember = value; // The value of the selected item
            destList.DisplayMember = key; // the value that will displayed at the list(name)
        }
        /// <summary>
        /// function get list of objects and insert them to the given ComboBox binding key and value
        /// 
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="destList">Combobox list to add to</param>
        /// <param name="sourceArr">array of data to insert to the combo box</param>
        /// <param name="key">The data to display(What user see)</param>
        /// <param name="value">the data that will be used on the item</param>
        private void fillCboList<T>(ComboBox destList, IEnumerable<T> sourceArr, string key, string value)
        {
            foreach (T item in sourceArr)
                destList.Items.Add(item);
            destList.ValueMember = value; // the value of the selected item at the list(supplier id)
            destList.DisplayMember = key;// the value that will displayed at the list(supplier name)
        }

        /// <summary>
        ///get data from db and loading the new data to the selected ListBox
        /// </summary>
        /// <param name="destList">Destination list to add the products</param>
        private void LoadProductsToList(ListBox destList)
        {
            refreshProducts();
            destList.Items.Clear();
            fillListBox(destList, products, "Name", "SupplierId");
        }

        /// <summary>
        ///get data from db and loading the new data to the selected ListBox
        /// </summary>
        /// <param name="destList">Destination list to add the suppliers</param>
        private void LoadSuppliersToList(ListBox destList)
        {
            refreshSuppliers();
            destList.Items.Clear();
            fillListBox(destList, suppliers, "Name", "Id");
        }

        /// <summary>
        ///get data from db and loading the new data to the selected ListBox
        /// </summary>
        /// <param name="destList">Destination list to add the customers</param>
        private void LoadCustomersToList(ListBox destList)
        {
            refreshCustomers();
            destList.Items.Clear();
            fillListBox(destList, customers, "FirstName", "Id");
        }
        /// <summary>
        ///get data from db and loading the new data to the selected ComboBox
        /// </summary>
        /// <param name="destList">Destination list to add the suppliers</param>
        private void LoadSuppliersToCbo(ComboBox destList)
        {
            refreshSuppliers();
            destList.Items.Clear();
            fillCboList(destList, suppliers, "Name", "Id");
        }

        // Loads customers to Listview in Customers tab
        private void LoadCustomersToListView(ListView destList)
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
                LoadCustomersToListView(lstvCustomers);
                ucEditCustomer.Clear();
                btnRemoveCustomerChange(ucEditCustomer, e);//notify the delete button to be disabled
            }

        }

        //Updating the product data to edit in Products tab
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProd = lstProducts.SelectedItem as Product;
            if (selectedProd != null)
            {
                cboEditProd.Enabled = txtEditProd.Enabled = true;
                cboEditProd.SelectedIndex = Array.FindIndex(suppliers, supplier => supplier.Id == selectedProd.SupplierId);
                txtEditProd.Text = selectedProd.Name;
            }
            else
                cboEditProd.Enabled = txtEditProd.Enabled = false;
        }

        /// <summary>
        /// handler when list of suppliers selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                ucEditSupplier.Supplier = selectedSupp; // insert the data to the uc fields
                if (lstSuppliers.SelectedIndex > -1)
                {
                    btnRemoveSupplier.Enabled = ucEditSupplier.Enabled = true;
                }
                else
                    btnRemoveSupplier.Enabled = ucEditSupplier.Enabled = false;

            }
        }

        /// <summary>
        /// handler when list of customers selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (Customer customer in customers)
            {
                if (customer.Id == Convert.ToInt32(lstvCustomers.FocusedItem.Text))
                {
                    ucEditCustomer.Customer = customer;
                    btnRemoveCustomerChange(ucEditCustomer, e);
                    if (ucEditCustomer.Customer.Id > -1) // if selected user the id should not be -1
                    {
                        ucEditCustomer.Enabled = true;
                    }
                    else
                        ucEditCustomer.Enabled = false;
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
                Product selectedProd = (Product)lstProducts.SelectedItem;
                if (MessageHandler.Show("Delete Product", $"Are you sure to delete this product?\n{selectedProd.Name}") == DialogResult.OK)
                    if (mySQL.DeleteProduct(selectedProd.Id))
                    {
                        LoadProductsToList(lstProducts);
                        clearEditProduct();
                        cboEditProd.Enabled = txtEditProd.Enabled = false;
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

            if (cboAddProd.SelectedItem != null)
            {
                addPrd.SupplierId = ((Supplier)cboAddProd.SelectedItem).Id;

                if (mySQL.InsertProduct(addPrd))
                {
                    LoadProductsToList(lstProducts);
                    clearAddProduct();
                }
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
            btnRemoveSupplierChange(sender, e);
        }


        private void ucEditSupplier_OnClearButtonClickEvent(object sender, EventArgs e)
        {
            lstSuppliers.SelectedItem = null;
            btnRemoveSupplierChange(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedItem != null)
                if (MessageHandler.Show("Delete", "Are you sure to delete this supplier?") == DialogResult.OK)
                {
                    if (mySQL.RemoveSupplier(((Supplier)lstSuppliers.SelectedItem).Id))
                    {
                        LoadSuppliersToList(lstSuppliers);
                        ucEditSupplier.Clear();
                        btnRemoveSupplier.Enabled = ucEditSupplier.Enabled = false;

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
                LoadCustomersToListView(lstvCustomers);
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
                        LoadCustomersToListView(lstvCustomers);
                        ucEditCustomer.Clear();
                        btnRemoveCustomerChange(ucEditCustomer, e);
                    }
                }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //i customer selected
            if (lstNewOrderCustomers.SelectedItem != null)
            {
                int orderId = mySQL.CreateOrder((Customer)lstNewOrderCustomers.SelectedItem);

                //if order created, starts inserting the product to the order list
                if (orderId != -1)
                {
                    //inserting each product to the db according the order id
                    for (int i = 0; i < lstOrderSelected.Items.Count; i++)
                        mySQL.AddOrderProduct(orderId, ((Product)lstOrderSelected.Items[i]).Id);
                    Console.WriteLine("Created order no: " + orderId);

                    //resets the lists to default
                    lstOrderSelected.Items.Clear();
                    lstNewOrderCustomers.SelectedIndex = -1;
                    LoadProductsToList(lstOrderProducts);
                }
            }
        }

        //Disables the button if customer not selected and at least 1 product not added
        private void btnOrder_Lock(object sender, EventArgs e)
        {
            btnOrder.Enabled = !(lstNewOrderCustomers.SelectedIndex == -1 || lstOrderSelected.Items.Count == 0);
        }


        //Moves product from list to another
        private void btnToCart_Click(object sender, EventArgs e)
        {
            if (lstOrderProducts.SelectedItem != null)
            {
                lstOrderSelected.Items.Add(lstOrderProducts.SelectedItem);
                int i = lstOrderProducts.SelectedIndex;
                lstOrderProducts.Items.RemoveAt(i);
                if (lstOrderProducts.Items.Count > 0)
                    lstOrderProducts.SelectedIndex = 0;
            }
        }

        //Removes selected item from the cart to the full list
        private void btnFromCart_Click(object sender, EventArgs e)
        {
            if (lstOrderSelected.SelectedItem != null)
            {
                lstOrderProducts.Items.Add(lstOrderSelected.SelectedItem);
                int i = lstOrderSelected.SelectedIndex;
                lstOrderSelected.Items.RemoveAt(i);
                if (lstOrderSelected.Items.Count > 0)
                    lstOrderSelected.SelectedIndex = 0;
            }
        }

        private void btnToCartAll_Click(object sender, EventArgs e)
        {
            for (int i = lstOrderProducts.Items.Count - 1; i >= 0; i--)
            {
                lstOrderSelected.Items.Add(lstOrderProducts.Items[i]);
                lstOrderProducts.Items.RemoveAt(i);

            }
        }

        private void btnFromCartAll_Click(object sender, EventArgs e)
        {
            for (int i = lstOrderSelected.Items.Count - 1; i >= 0; i--)
            {
                lstOrderProducts.Items.Add(lstOrderSelected.Items[i]);
                lstOrderSelected.Items.RemoveAt(i);

            }
        }

        private void lstDisplayOrderCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selectedCust = lstDisplayOrderCustomers.SelectedItem as Customer;
            refreshOrders();
            lstvOrders.Items.Clear();
            lstvOrderProducts.Items.Clear();
            if (selectedCust != null)
            {
                foreach (Order ord in orders)
                {
                    if (ord.CustomerId == selectedCust.Id)
                    {
                        string[] dt = ord.DateTime.Split(' ');
                        string[] row = { ord.Id.ToString(), dt[0], dt[1] };
                        ListViewItem itm = new ListViewItem(row);
                        lstvOrders.Items.Add(itm);
                    }
                }
            }
        }

        private void lstvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstvOrderProducts.Items.Clear();
            foreach (Order ord in orders)
            {
                Console.WriteLine(lstvOrders.FocusedItem.Text);
                if (ord.Id == Convert.ToInt32(lstvOrders.FocusedItem.Text))
                {
                    OrderProduct[] orderProducts = mySQL.GetOrderedProductsById(ord.Id);
                    if (orderProducts != null)
                        foreach (OrderProduct prod in orderProducts)
                        {
                            string[] row = { prod.Id.ToString(), prod.Name, prod.SupplierId.ToString() };
                            ListViewItem itm = new ListViewItem(row);
                            lstvOrderProducts.Items.Add(itm);
                        }
                }
            }
        }

        // Saving customers list to pdf file using save file dialog
        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = "C:\\";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.FileName = "customers list.pdf";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK) // if selected valid path & name
            {
                PdfMaker pdfFile = new PdfMaker(Path.GetFullPath(saveFileDialog.FileName));
                pdfFile.AddParagraph("Customers list:");
                pdfFile.AddSpace();
                LoadCustomersToListView(lstvCustomers);
                pdfFile.addTable(lstvCustomers);
                lstvCustomers.Items.Clear();
                pdfFile.CloseReport();
            }



        }

        //Enable/Disable the Add Product button according the related inputs
        private void btnAddProduct_Lock(object sender, EventArgs e)
        {

            btnAddProd.Enabled = !(cboAddProd.SelectedIndex == -1 || txtAddProd.Text.Length == 0);

        }

        //Enable/Disable the Delete button according the UC form
        private void btnRemoveSupplierChange(object sender, EventArgs e)
        {
            btnRemoveSupplier.Enabled = ucEditSupplier.Enabled = ((SupplierForm)sender).isBtnEnabled;
        }

        private void btnRemoveCustomerChange(object sender, EventArgs e)
        {
            btnRemoveCustomer.Enabled = ucEditCustomer.Enabled = ((CustomerForm)sender).isBtnEnabled;
        }

        private void btnAddProductLock(object sender, EventArgs e)
        {
            btnEditProd.Enabled = btnRemoveProd.Enabled = !(lstProducts.SelectedIndex == -1 || cboEditProd.SelectedIndex == -1);
            btnEditProd.Enabled = !string.IsNullOrEmpty(txtEditProd.Text);// unable to save if there is no text
        }
    }
}
