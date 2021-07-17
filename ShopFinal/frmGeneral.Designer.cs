
namespace ShopFinal
{
    partial class frmGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ShopFinal.Supplier supplier7 = new ShopFinal.Supplier();
            ShopFinal.Supplier supplier8 = new ShopFinal.Supplier();
            ShopFinal.Customer customer7 = new ShopFinal.Customer();
            ShopFinal.Customer customer8 = new ShopFinal.Customer();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnRemoveProd = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.lblEdit1 = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblAddProd = new System.Windows.Forms.Label();
            this.lblSuppName2 = new System.Windows.Forms.Label();
            this.cboAddProd = new System.Windows.Forms.ComboBox();
            this.txtAddProd = new System.Windows.Forms.TextBox();
            this.lblEditProd = new System.Windows.Forms.Label();
            this.lblSuppName1 = new System.Windows.Forms.Label();
            this.cboEditProd = new System.Windows.Forms.ComboBox();
            this.txtEditProd = new System.Windows.Forms.TextBox();
            this.lblProdTitle = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.lblAddSupp = new System.Windows.Forms.Label();
            this.lstvProducts = new System.Windows.Forms.ListView();
            this.txtSuppliers = new System.Windows.Forms.Label();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.lblTitleAddCustomer = new System.Windows.Forms.Label();
            this.lblTitleEditCustomer = new System.Windows.Forms.Label();
            this.lstvCustomers = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.lstNewOrderCustomers = new System.Windows.Forms.ListBox();
            this.btnToCartAll = new System.Windows.Forms.Button();
            this.btnFromCartAll = new System.Windows.Forms.Button();
            this.btnFromCart = new System.Windows.Forms.Button();
            this.btnToCart = new System.Windows.Forms.Button();
            this.lstOrderSelected = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lstOrderProducts = new System.Windows.Forms.ListBox();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.lstvOrderProducts = new System.Windows.Forms.ListView();
            this.lstvOrders = new System.Windows.Forms.ListView();
            this.lstDisplayOrderCustomers = new System.Windows.Forms.ListBox();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.ucEditSupplier = new ShopFinal.SupplierForm();
            this.ucAddSupplier = new ShopFinal.SupplierForm();
            this.ucAddCustomer = new ShopFinal.CustomerForm();
            this.ucEditCustomer = new ShopFinal.CustomerForm();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabMain.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(12, 37);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(145, 264);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabProducts);
            this.tabMain.Controls.Add(this.tabSuppliers);
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Controls.Add(this.tabCreate);
            this.tabMain.Controls.Add(this.tabOrders);
            this.tabMain.Controls.Add(this.tabReport);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(681, 408);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btnAddProd);
            this.tabProducts.Controls.Add(this.btnRemoveProd);
            this.tabProducts.Controls.Add(this.btnEditProd);
            this.tabProducts.Controls.Add(this.lblEdit1);
            this.tabProducts.Controls.Add(this.lblAdd1);
            this.tabProducts.Controls.Add(this.lblAddProd);
            this.tabProducts.Controls.Add(this.lblSuppName2);
            this.tabProducts.Controls.Add(this.cboAddProd);
            this.tabProducts.Controls.Add(this.txtAddProd);
            this.tabProducts.Controls.Add(this.lblEditProd);
            this.tabProducts.Controls.Add(this.lblSuppName1);
            this.tabProducts.Controls.Add(this.cboEditProd);
            this.tabProducts.Controls.Add(this.txtEditProd);
            this.tabProducts.Controls.Add(this.lblProdTitle);
            this.tabProducts.Controls.Add(this.lstProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(673, 382);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(318, 224);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 21);
            this.btnAddProd.TabIndex = 15;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnRemoveProd
            // 
            this.btnRemoveProd.Location = new System.Drawing.Point(318, 122);
            this.btnRemoveProd.Name = "btnRemoveProd";
            this.btnRemoveProd.Size = new System.Drawing.Size(75, 20);
            this.btnRemoveProd.TabIndex = 14;
            this.btnRemoveProd.Text = "Remove";
            this.btnRemoveProd.UseVisualStyleBackColor = true;
            this.btnRemoveProd.Click += new System.EventHandler(this.btnRemoveProd_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(318, 82);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(75, 20);
            this.btnEditProd.TabIndex = 13;
            this.btnEditProd.Text = "Save";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // lblEdit1
            // 
            this.lblEdit1.AutoSize = true;
            this.lblEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit1.Location = new System.Drawing.Point(179, 37);
            this.lblEdit1.Name = "lblEdit1";
            this.lblEdit1.Size = new System.Drawing.Size(49, 25);
            this.lblEdit1.TabIndex = 12;
            this.lblEdit1.Text = "Edit";
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.Location = new System.Drawing.Point(179, 183);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(95, 25);
            this.lblAdd1.TabIndex = 11;
            this.lblAdd1.Text = "Add new";
            // 
            // lblAddProd
            // 
            this.lblAddProd.AutoSize = true;
            this.lblAddProd.Location = new System.Drawing.Point(181, 249);
            this.lblAddProd.Name = "lblAddProd";
            this.lblAddProd.Size = new System.Drawing.Size(76, 13);
            this.lblAddProd.TabIndex = 10;
            this.lblAddProd.Text = "Product name:";
            // 
            // lblSuppName2
            // 
            this.lblSuppName2.AutoSize = true;
            this.lblSuppName2.Location = new System.Drawing.Point(181, 208);
            this.lblSuppName2.Name = "lblSuppName2";
            this.lblSuppName2.Size = new System.Drawing.Size(77, 13);
            this.lblSuppName2.TabIndex = 9;
            this.lblSuppName2.Text = "Supplier name:";
            // 
            // cboAddProd
            // 
            this.cboAddProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddProd.FormattingEnabled = true;
            this.cboAddProd.Location = new System.Drawing.Point(184, 224);
            this.cboAddProd.Name = "cboAddProd";
            this.cboAddProd.Size = new System.Drawing.Size(96, 21);
            this.cboAddProd.TabIndex = 8;
            // 
            // txtAddProd
            // 
            this.txtAddProd.Location = new System.Drawing.Point(184, 266);
            this.txtAddProd.Name = "txtAddProd";
            this.txtAddProd.Size = new System.Drawing.Size(100, 20);
            this.txtAddProd.TabIndex = 7;
            // 
            // lblEditProd
            // 
            this.lblEditProd.AutoSize = true;
            this.lblEditProd.Location = new System.Drawing.Point(181, 106);
            this.lblEditProd.Name = "lblEditProd";
            this.lblEditProd.Size = new System.Drawing.Size(76, 13);
            this.lblEditProd.TabIndex = 6;
            this.lblEditProd.Text = "Product name:";
            // 
            // lblSuppName1
            // 
            this.lblSuppName1.AutoSize = true;
            this.lblSuppName1.Location = new System.Drawing.Point(181, 65);
            this.lblSuppName1.Name = "lblSuppName1";
            this.lblSuppName1.Size = new System.Drawing.Size(77, 13);
            this.lblSuppName1.TabIndex = 5;
            this.lblSuppName1.Text = "Supplier name:";
            // 
            // cboEditProd
            // 
            this.cboEditProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditProd.FormattingEnabled = true;
            this.cboEditProd.Location = new System.Drawing.Point(184, 81);
            this.cboEditProd.Name = "cboEditProd";
            this.cboEditProd.Size = new System.Drawing.Size(96, 21);
            this.cboEditProd.TabIndex = 4;
            // 
            // txtEditProd
            // 
            this.txtEditProd.Location = new System.Drawing.Point(184, 123);
            this.txtEditProd.Name = "txtEditProd";
            this.txtEditProd.Size = new System.Drawing.Size(100, 20);
            this.txtEditProd.TabIndex = 3;
            // 
            // lblProdTitle
            // 
            this.lblProdTitle.AutoSize = true;
            this.lblProdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdTitle.Location = new System.Drawing.Point(6, 3);
            this.lblProdTitle.Name = "lblProdTitle";
            this.lblProdTitle.Size = new System.Drawing.Size(122, 31);
            this.lblProdTitle.TabIndex = 1;
            this.lblProdTitle.Text = "Products";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.btnRemoveSupplier);
            this.tabSuppliers.Controls.Add(this.lblAddSupp);
            this.tabSuppliers.Controls.Add(this.ucEditSupplier);
            this.tabSuppliers.Controls.Add(this.ucAddSupplier);
            this.tabSuppliers.Controls.Add(this.lstvProducts);
            this.tabSuppliers.Controls.Add(this.txtSuppliers);
            this.tabSuppliers.Controls.Add(this.lstSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(673, 382);
            this.tabSuppliers.TabIndex = 1;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Location = new System.Drawing.Point(166, 271);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSupplier.TabIndex = 25;
            this.btnRemoveSupplier.Text = "Delete";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblAddSupp
            // 
            this.lblAddSupp.AutoSize = true;
            this.lblAddSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupp.Location = new System.Drawing.Point(495, 37);
            this.lblAddSupp.Name = "lblAddSupp";
            this.lblAddSupp.Size = new System.Drawing.Size(95, 25);
            this.lblAddSupp.TabIndex = 21;
            this.lblAddSupp.Text = "Add new";
            // 
            // lstvProducts
            // 
            this.lstvProducts.HideSelection = false;
            this.lstvProducts.Location = new System.Drawing.Point(165, 37);
            this.lstvProducts.Name = "lstvProducts";
            this.lstvProducts.Size = new System.Drawing.Size(324, 227);
            this.lstvProducts.TabIndex = 4;
            this.lstvProducts.UseCompatibleStateImageBehavior = false;
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.AutoSize = true;
            this.txtSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppliers.Location = new System.Drawing.Point(0, 3);
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(127, 31);
            this.txtSuppliers.TabIndex = 3;
            this.txtSuppliers.Text = "Suppliers";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(6, 37);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(153, 147);
            this.lstSuppliers.TabIndex = 2;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.btnRemoveCustomer);
            this.tabCustomers.Controls.Add(this.lblTitleAddCustomer);
            this.tabCustomers.Controls.Add(this.lblTitleEditCustomer);
            this.tabCustomers.Controls.Add(this.ucAddCustomer);
            this.tabCustomers.Controls.Add(this.ucEditCustomer);
            this.tabCustomers.Controls.Add(this.lstvCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(673, 382);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(13, 181);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveCustomer.TabIndex = 8;
            this.btnRemoveCustomer.Text = "Delete";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // lblTitleAddCustomer
            // 
            this.lblTitleAddCustomer.AutoSize = true;
            this.lblTitleAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAddCustomer.Location = new System.Drawing.Point(9, 230);
            this.lblTitleAddCustomer.Name = "lblTitleAddCustomer";
            this.lblTitleAddCustomer.Size = new System.Drawing.Size(102, 24);
            this.lblTitleAddCustomer.TabIndex = 7;
            this.lblTitleAddCustomer.Text = "Add New:";
            // 
            // lblTitleEditCustomer
            // 
            this.lblTitleEditCustomer.AutoSize = true;
            this.lblTitleEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEditCustomer.Location = new System.Drawing.Point(9, 34);
            this.lblTitleEditCustomer.Name = "lblTitleEditCustomer";
            this.lblTitleEditCustomer.Size = new System.Drawing.Size(52, 24);
            this.lblTitleEditCustomer.TabIndex = 6;
            this.lblTitleEditCustomer.Text = "Edit:";
            // 
            // lstvCustomers
            // 
            this.lstvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.firstName,
            this.lastName});
            this.lstvCustomers.HideSelection = false;
            this.lstvCustomers.Location = new System.Drawing.Point(185, 34);
            this.lstvCustomers.Name = "lstvCustomers";
            this.lstvCustomers.Size = new System.Drawing.Size(314, 335);
            this.lstvCustomers.TabIndex = 3;
            this.lstvCustomers.UseCompatibleStateImageBehavior = false;
            this.lstvCustomers.SelectedIndexChanged += new System.EventHandler(this.lstvCustomers_SelectedIndexChanged);
            this.lstvCustomers.MouseLeave += new System.EventHandler(this.lstvCustomers_MouseLeave);
            // 
            // idCol
            // 
            this.idCol.Text = "ID";
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 100;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 100;
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.lstNewOrderCustomers);
            this.tabCreate.Controls.Add(this.btnToCartAll);
            this.tabCreate.Controls.Add(this.btnFromCartAll);
            this.tabCreate.Controls.Add(this.btnFromCart);
            this.tabCreate.Controls.Add(this.btnToCart);
            this.tabCreate.Controls.Add(this.lstOrderSelected);
            this.tabCreate.Controls.Add(this.btnOrder);
            this.tabCreate.Controls.Add(this.lstOrderProducts);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Size = new System.Drawing.Size(673, 382);
            this.tabCreate.TabIndex = 4;
            this.tabCreate.Text = "New Order";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // lstNewOrderCustomers
            // 
            this.lstNewOrderCustomers.FormattingEnabled = true;
            this.lstNewOrderCustomers.Location = new System.Drawing.Point(14, 12);
            this.lstNewOrderCustomers.MultiColumn = true;
            this.lstNewOrderCustomers.Name = "lstNewOrderCustomers";
            this.lstNewOrderCustomers.Size = new System.Drawing.Size(188, 95);
            this.lstNewOrderCustomers.TabIndex = 7;
            this.lstNewOrderCustomers.SelectedIndexChanged += new System.EventHandler(this.btnOrder_Lock);
            // 
            // btnToCartAll
            // 
            this.btnToCartAll.Location = new System.Drawing.Point(145, 260);
            this.btnToCartAll.Name = "btnToCartAll";
            this.btnToCartAll.Size = new System.Drawing.Size(48, 23);
            this.btnToCartAll.TabIndex = 6;
            this.btnToCartAll.Text = ">>";
            this.btnToCartAll.UseVisualStyleBackColor = true;
            this.btnToCartAll.Click += new System.EventHandler(this.btnToCartAll_Click);
            // 
            // btnFromCartAll
            // 
            this.btnFromCartAll.Location = new System.Drawing.Point(145, 289);
            this.btnFromCartAll.Name = "btnFromCartAll";
            this.btnFromCartAll.Size = new System.Drawing.Size(48, 23);
            this.btnFromCartAll.TabIndex = 5;
            this.btnFromCartAll.Text = "<<";
            this.btnFromCartAll.UseVisualStyleBackColor = true;
            this.btnFromCartAll.Click += new System.EventHandler(this.btnFromCartAll_Click);
            // 
            // btnFromCart
            // 
            this.btnFromCart.Location = new System.Drawing.Point(145, 142);
            this.btnFromCart.Name = "btnFromCart";
            this.btnFromCart.Size = new System.Drawing.Size(48, 23);
            this.btnFromCart.TabIndex = 4;
            this.btnFromCart.Text = "<";
            this.btnFromCart.UseVisualStyleBackColor = true;
            this.btnFromCart.Click += new System.EventHandler(this.btnFromCart_Click);
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(145, 113);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(48, 23);
            this.btnToCart.TabIndex = 3;
            this.btnToCart.Text = ">";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // lstOrderSelected
            // 
            this.lstOrderSelected.FormattingEnabled = true;
            this.lstOrderSelected.Location = new System.Drawing.Point(199, 113);
            this.lstOrderSelected.Name = "lstOrderSelected";
            this.lstOrderSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstOrderSelected.Size = new System.Drawing.Size(125, 199);
            this.lstOrderSelected.TabIndex = 2;
            this.lstOrderSelected.SelectedIndexChanged += new System.EventHandler(this.btnOrder_Lock);
            this.lstOrderSelected.DoubleClick += new System.EventHandler(this.btnFromCart_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Enabled = false;
            this.btnOrder.Location = new System.Drawing.Point(127, 318);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Create Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lstOrderProducts
            // 
            this.lstOrderProducts.FormattingEnabled = true;
            this.lstOrderProducts.Location = new System.Drawing.Point(14, 113);
            this.lstOrderProducts.Name = "lstOrderProducts";
            this.lstOrderProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstOrderProducts.Size = new System.Drawing.Size(125, 199);
            this.lstOrderProducts.TabIndex = 0;
            this.lstOrderProducts.SelectedIndexChanged += new System.EventHandler(this.btnOrder_Lock);
            this.lstOrderProducts.DoubleClick += new System.EventHandler(this.btnToCart_Click);
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.lstvOrderProducts);
            this.tabOrders.Controls.Add(this.lstvOrders);
            this.tabOrders.Controls.Add(this.lstDisplayOrderCustomers);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(673, 382);
            this.tabOrders.TabIndex = 3;
            this.tabOrders.Text = "Display Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // lstvOrderProducts
            // 
            this.lstvOrderProducts.HideSelection = false;
            this.lstvOrderProducts.Location = new System.Drawing.Point(315, 7);
            this.lstvOrderProducts.Name = "lstvOrderProducts";
            this.lstvOrderProducts.Size = new System.Drawing.Size(352, 237);
            this.lstvOrderProducts.TabIndex = 2;
            this.lstvOrderProducts.UseCompatibleStateImageBehavior = false;
            // 
            // lstvOrders
            // 
            this.lstvOrders.HideSelection = false;
            this.lstvOrders.Location = new System.Drawing.Point(132, 6);
            this.lstvOrders.Name = "lstvOrders";
            this.lstvOrders.Size = new System.Drawing.Size(176, 238);
            this.lstvOrders.TabIndex = 1;
            this.lstvOrders.UseCompatibleStateImageBehavior = false;
            this.lstvOrders.SelectedIndexChanged += new System.EventHandler(this.lstvOrders_SelectedIndexChanged);
            // 
            // lstDisplayOrderCustomers
            // 
            this.lstDisplayOrderCustomers.FormattingEnabled = true;
            this.lstDisplayOrderCustomers.Location = new System.Drawing.Point(6, 6);
            this.lstDisplayOrderCustomers.Name = "lstDisplayOrderCustomers";
            this.lstDisplayOrderCustomers.Size = new System.Drawing.Size(120, 238);
            this.lstDisplayOrderCustomers.TabIndex = 0;
            this.lstDisplayOrderCustomers.SelectedIndexChanged += new System.EventHandler(this.lstDisplayOrderCustomers_SelectedIndexChanged);
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.btnExport);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(673, 382);
            this.tabReport.TabIndex = 5;
            this.tabReport.Text = "Reports";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(298, 183);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export to Pdf";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ucEditSupplier
            // 
            this.ucEditSupplier.Location = new System.Drawing.Point(6, 186);
            this.ucEditSupplier.Name = "ucEditSupplier";
            this.ucEditSupplier.Size = new System.Drawing.Size(153, 189);
            supplier7.Address = "";
            supplier7.Email = "";
            supplier7.Id = -1;
            supplier7.Name = "";
            supplier7.Phone = "";
            this.ucEditSupplier.Supplier = supplier7;
            this.ucEditSupplier.TabIndex = 24;
            this.ucEditSupplier.OnSaveButtonClickEvent += new ShopFinal.SupplierForm.SaveButtonClickEvent(this.ucEditSupplier_OnSaveButtonClickEvent);
            this.ucEditSupplier.OnClearButtonClickEvent += new ShopFinal.SupplierForm.ClearButtonClickEvent(this.ucEditSupplier_OnClearButtonClickEvent);
            // 
            // ucAddSupplier
            // 
            this.ucAddSupplier.Location = new System.Drawing.Point(495, 75);
            this.ucAddSupplier.Name = "ucAddSupplier";
            this.ucAddSupplier.Size = new System.Drawing.Size(153, 189);
            supplier8.Address = "";
            supplier8.Email = "";
            supplier8.Id = -1;
            supplier8.Name = "";
            supplier8.Phone = "";
            this.ucAddSupplier.Supplier = supplier8;
            this.ucAddSupplier.TabIndex = 23;
            this.ucAddSupplier.OnSaveButtonClickEvent += new ShopFinal.SupplierForm.SaveButtonClickEvent(this.ucAddSupplier_onSaveButtonClickEvent);
            // 
            // ucAddCustomer
            // 
            customer7.FirstName = "";
            customer7.Id = -1;
            customer7.LastName = "";
            this.ucAddCustomer.Customer = customer7;
            this.ucAddCustomer.Location = new System.Drawing.Point(12, 257);
            this.ucAddCustomer.Name = "ucAddCustomer";
            this.ucAddCustomer.Size = new System.Drawing.Size(150, 112);
            this.ucAddCustomer.TabIndex = 5;
            this.ucAddCustomer.OnSaveButtonClickEvent += new ShopFinal.CustomerForm.SaveButtonClickEvent(this.ucAddCustomer_OnSaveButtonClickEvent);
            // 
            // ucEditCustomer
            // 
            customer8.FirstName = "";
            customer8.Id = -1;
            customer8.LastName = "";
            this.ucEditCustomer.Customer = customer8;
            this.ucEditCustomer.Location = new System.Drawing.Point(12, 63);
            this.ucEditCustomer.Name = "ucEditCustomer";
            this.ucEditCustomer.Size = new System.Drawing.Size(150, 112);
            this.ucEditCustomer.TabIndex = 4;
            this.ucEditCustomer.OnSaveButtonClickEvent += new ShopFinal.CustomerForm.SaveButtonClickEvent(this.ucEditCustomer_OnSaveButtonClickEvent);
            // 
            // saveFileDIalog
            // 
            this.saveFileDialog.DefaultExt = "pdf";
            this.saveFileDialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save to PDF";
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 433);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Management";
            this.tabMain.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.tabCreate.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.Label lblProdTitle;
        private System.Windows.Forms.ComboBox cboEditProd;
        private System.Windows.Forms.TextBox txtEditProd;
        private System.Windows.Forms.Label lblEditProd;
        private System.Windows.Forms.Label lblSuppName1;
        private System.Windows.Forms.Label lblEdit1;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblAddProd;
        private System.Windows.Forms.Label lblSuppName2;
        private System.Windows.Forms.ComboBox cboAddProd;
        private System.Windows.Forms.TextBox txtAddProd;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnRemoveProd;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.ListView lstvProducts;
        private System.Windows.Forms.Label txtSuppliers;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.Label lblAddSupp;
        private SupplierForm ucAddSupplier;
        private SupplierForm ucEditSupplier;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.ListView lstvCustomers;
        private System.Windows.Forms.ColumnHeader idCol;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private CustomerForm ucEditCustomer;
        private System.Windows.Forms.Label lblTitleAddCustomer;
        private System.Windows.Forms.Label lblTitleEditCustomer;
        private CustomerForm ucAddCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.ListBox lstOrderProducts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.ListBox lstOrderSelected;
        private System.Windows.Forms.Button btnFromCart;
        private System.Windows.Forms.Button btnToCartAll;
        private System.Windows.Forms.Button btnFromCartAll;
        private System.Windows.Forms.ListBox lstNewOrderCustomers;
        private System.Windows.Forms.ListBox lstDisplayOrderCustomers;
        private System.Windows.Forms.ListView lstvOrders;
        private System.Windows.Forms.ListView lstvOrderProducts;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

