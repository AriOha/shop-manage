
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
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.btnEditSupp = new System.Windows.Forms.Button();
            this.lblAddSupp = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.lblAddPhone = new System.Windows.Forms.Label();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.txtAddSupp = new System.Windows.Forms.TextBox();
            this.lblAddSuppName = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.lblEditPhone = new System.Windows.Forms.Label();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.lblEditAddress = new System.Windows.Forms.Label();
            this.txtEditSupp = new System.Windows.Forms.TextBox();
            this.lblEditSuppName = new System.Windows.Forms.Label();
            this.lstvProducts = new System.Windows.Forms.ListView();
            this.txtSuppliers = new System.Windows.Forms.Label();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
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
            this.tabMain.Controls.Add(this.tabOrders);
            this.tabMain.Controls.Add(this.tabCreate);
            this.tabMain.Controls.Add(this.tabReport);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(662, 346);
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
            this.tabProducts.Size = new System.Drawing.Size(654, 320);
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
            this.tabSuppliers.Controls.Add(this.btnAddSupp);
            this.tabSuppliers.Controls.Add(this.btnEditSupp);
            this.tabSuppliers.Controls.Add(this.lblAddSupp);
            this.tabSuppliers.Controls.Add(this.txtAddEmail);
            this.tabSuppliers.Controls.Add(this.lblAddEmail);
            this.tabSuppliers.Controls.Add(this.txtAddPhone);
            this.tabSuppliers.Controls.Add(this.lblAddPhone);
            this.tabSuppliers.Controls.Add(this.txtAddAddress);
            this.tabSuppliers.Controls.Add(this.lblAddAddress);
            this.tabSuppliers.Controls.Add(this.txtAddSupp);
            this.tabSuppliers.Controls.Add(this.lblAddSuppName);
            this.tabSuppliers.Controls.Add(this.txtEditEmail);
            this.tabSuppliers.Controls.Add(this.lblEditEmail);
            this.tabSuppliers.Controls.Add(this.txtEditPhone);
            this.tabSuppliers.Controls.Add(this.lblEditPhone);
            this.tabSuppliers.Controls.Add(this.txtEditAddress);
            this.tabSuppliers.Controls.Add(this.lblEditAddress);
            this.tabSuppliers.Controls.Add(this.txtEditSupp);
            this.tabSuppliers.Controls.Add(this.lblEditSuppName);
            this.tabSuppliers.Controls.Add(this.lstvProducts);
            this.tabSuppliers.Controls.Add(this.txtSuppliers);
            this.tabSuppliers.Controls.Add(this.lstSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(654, 320);
            this.tabSuppliers.TabIndex = 1;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Location = new System.Drawing.Point(488, 226);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(145, 20);
            this.btnAddSupp.TabIndex = 23;
            this.btnAddSupp.Text = "Save";
            this.btnAddSupp.UseVisualStyleBackColor = true;
            // 
            // btnEditSupp
            // 
            this.btnEditSupp.Location = new System.Drawing.Point(157, 281);
            this.btnEditSupp.Name = "btnEditSupp";
            this.btnEditSupp.Size = new System.Drawing.Size(80, 20);
            this.btnEditSupp.TabIndex = 22;
            this.btnEditSupp.Text = "Save";
            this.btnEditSupp.UseVisualStyleBackColor = true;
            // 
            // lblAddSupp
            // 
            this.lblAddSupp.AutoSize = true;
            this.lblAddSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSupp.Location = new System.Drawing.Point(487, 37);
            this.lblAddSupp.Name = "lblAddSupp";
            this.lblAddSupp.Size = new System.Drawing.Size(95, 25);
            this.lblAddSupp.TabIndex = 21;
            this.lblAddSupp.Text = "Add new";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(488, 198);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(145, 20);
            this.txtAddEmail.TabIndex = 20;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(489, 182);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(35, 13);
            this.lblAddEmail.TabIndex = 19;
            this.lblAddEmail.Text = "Email:";
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(488, 159);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(145, 20);
            this.txtAddPhone.TabIndex = 18;
            // 
            // lblAddPhone
            // 
            this.lblAddPhone.AutoSize = true;
            this.lblAddPhone.Location = new System.Drawing.Point(489, 143);
            this.lblAddPhone.Name = "lblAddPhone";
            this.lblAddPhone.Size = new System.Drawing.Size(41, 13);
            this.lblAddPhone.TabIndex = 17;
            this.lblAddPhone.Text = "Phone:";
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(488, 120);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(145, 20);
            this.txtAddAddress.TabIndex = 16;
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.AutoSize = true;
            this.lblAddAddress.Location = new System.Drawing.Point(489, 104);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddAddress.TabIndex = 15;
            this.lblAddAddress.Text = "Address:";
            // 
            // txtAddSupp
            // 
            this.txtAddSupp.Location = new System.Drawing.Point(488, 81);
            this.txtAddSupp.Name = "txtAddSupp";
            this.txtAddSupp.Size = new System.Drawing.Size(145, 20);
            this.txtAddSupp.TabIndex = 14;
            // 
            // lblAddSuppName
            // 
            this.lblAddSuppName.AutoSize = true;
            this.lblAddSuppName.Location = new System.Drawing.Point(489, 65);
            this.lblAddSuppName.Name = "lblAddSuppName";
            this.lblAddSuppName.Size = new System.Drawing.Size(38, 13);
            this.lblAddSuppName.TabIndex = 13;
            this.lblAddSuppName.Text = "Name:";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(5, 281);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEditEmail.TabIndex = 12;
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Location = new System.Drawing.Point(6, 265);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEditEmail.TabIndex = 11;
            this.lblEditEmail.Text = "Email:";
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(5, 242);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(145, 20);
            this.txtEditPhone.TabIndex = 10;
            // 
            // lblEditPhone
            // 
            this.lblEditPhone.AutoSize = true;
            this.lblEditPhone.Location = new System.Drawing.Point(6, 226);
            this.lblEditPhone.Name = "lblEditPhone";
            this.lblEditPhone.Size = new System.Drawing.Size(41, 13);
            this.lblEditPhone.TabIndex = 9;
            this.lblEditPhone.Text = "Phone:";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(5, 203);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(145, 20);
            this.txtEditAddress.TabIndex = 8;
            // 
            // lblEditAddress
            // 
            this.lblEditAddress.AutoSize = true;
            this.lblEditAddress.Location = new System.Drawing.Point(6, 187);
            this.lblEditAddress.Name = "lblEditAddress";
            this.lblEditAddress.Size = new System.Drawing.Size(48, 13);
            this.lblEditAddress.TabIndex = 7;
            this.lblEditAddress.Text = "Address:";
            // 
            // txtEditSupp
            // 
            this.txtEditSupp.Location = new System.Drawing.Point(5, 164);
            this.txtEditSupp.Name = "txtEditSupp";
            this.txtEditSupp.Size = new System.Drawing.Size(145, 20);
            this.txtEditSupp.TabIndex = 6;
            // 
            // lblEditSuppName
            // 
            this.lblEditSuppName.AutoSize = true;
            this.lblEditSuppName.Location = new System.Drawing.Point(6, 148);
            this.lblEditSuppName.Name = "lblEditSuppName";
            this.lblEditSuppName.Size = new System.Drawing.Size(38, 13);
            this.lblEditSuppName.TabIndex = 5;
            this.lblEditSuppName.Text = "Name:";
            // 
            // lstvProducts
            // 
            this.lstvProducts.HideSelection = false;
            this.lstvProducts.Location = new System.Drawing.Point(157, 37);
            this.lstvProducts.Name = "lstvProducts";
            this.lstvProducts.Size = new System.Drawing.Size(324, 241);
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
            this.txtSuppliers.Text = "Supplires";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(6, 37);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(145, 108);
            this.lstSuppliers.TabIndex = 2;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(654, 320);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabOrders
            // 
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(654, 320);
            this.tabOrders.TabIndex = 3;
            this.tabOrders.Text = "Display Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // tabCreate
            // 
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Size = new System.Drawing.Size(654, 320);
            this.tabCreate.TabIndex = 4;
            this.tabCreate.Text = "New Order";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Size = new System.Drawing.Size(654, 320);
            this.tabReport.TabIndex = 5;
            this.tabReport.Text = "Reports";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 371);
            this.Controls.Add(this.tabMain);
            this.Name = "frmGeneral";
            this.Text = "Shop Management";
            this.tabMain.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
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
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.Label lblAddPhone;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.TextBox txtAddSupp;
        private System.Windows.Forms.Label lblAddSuppName;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.Label lblEditPhone;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label lblEditAddress;
        private System.Windows.Forms.TextBox txtEditSupp;
        private System.Windows.Forms.Label lblEditSuppName;
        private System.Windows.Forms.Button btnAddSupp;
        private System.Windows.Forms.Button btnEditSupp;
    }
}

