
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnRemoveProd = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddProd = new System.Windows.Forms.Label();
            this.lblAddSupp = new System.Windows.Forms.Label();
            this.cboAddProd = new System.Windows.Forms.ComboBox();
            this.txtAddProd = new System.Windows.Forms.TextBox();
            this.lblEditProd = new System.Windows.Forms.Label();
            this.lblEditSupp = new System.Windows.Forms.Label();
            this.cboEditSupp = new System.Windows.Forms.ComboBox();
            this.txtEditProd = new System.Windows.Forms.TextBox();
            this.lblProdTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(20, 75);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(145, 225);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 346);
            this.tabControl1.TabIndex = 1;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btnAddProd);
            this.tabProducts.Controls.Add(this.btnRemoveProd);
            this.tabProducts.Controls.Add(this.btnEditProd);
            this.tabProducts.Controls.Add(this.label4);
            this.tabProducts.Controls.Add(this.label3);
            this.tabProducts.Controls.Add(this.lblAddProd);
            this.tabProducts.Controls.Add(this.lblAddSupp);
            this.tabProducts.Controls.Add(this.cboAddProd);
            this.tabProducts.Controls.Add(this.txtAddProd);
            this.tabProducts.Controls.Add(this.lblEditProd);
            this.tabProducts.Controls.Add(this.lblEditSupp);
            this.tabProducts.Controls.Add(this.cboEditSupp);
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
            this.btnAddProd.Location = new System.Drawing.Point(449, 263);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 20);
            this.btnAddProd.TabIndex = 15;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProd
            // 
            this.btnRemoveProd.Location = new System.Drawing.Point(530, 120);
            this.btnRemoveProd.Name = "btnRemoveProd";
            this.btnRemoveProd.Size = new System.Drawing.Size(75, 20);
            this.btnRemoveProd.TabIndex = 14;
            this.btnRemoveProd.Text = "Remove";
            this.btnRemoveProd.UseVisualStyleBackColor = true;
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(449, 120);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(75, 20);
            this.btnEditProd.TabIndex = 13;
            this.btnEditProd.Text = "Save";
            this.btnEditProd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Edit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add new";
            // 
            // lblAddProd
            // 
            this.lblAddProd.AutoSize = true;
            this.lblAddProd.Location = new System.Drawing.Point(326, 246);
            this.lblAddProd.Name = "lblAddProd";
            this.lblAddProd.Size = new System.Drawing.Size(76, 13);
            this.lblAddProd.TabIndex = 10;
            this.lblAddProd.Text = "Product name:";
            // 
            // lblAddSupp
            // 
            this.lblAddSupp.AutoSize = true;
            this.lblAddSupp.Location = new System.Drawing.Point(212, 246);
            this.lblAddSupp.Name = "lblAddSupp";
            this.lblAddSupp.Size = new System.Drawing.Size(77, 13);
            this.lblAddSupp.TabIndex = 9;
            this.lblAddSupp.Text = "Supplier name:";
            // 
            // cboAddProd
            // 
            this.cboAddProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddProd.FormattingEnabled = true;
            this.cboAddProd.Location = new System.Drawing.Point(215, 262);
            this.cboAddProd.Name = "cboAddProd";
            this.cboAddProd.Size = new System.Drawing.Size(96, 21);
            this.cboAddProd.TabIndex = 8;
            // 
            // txtAddProd
            // 
            this.txtAddProd.Location = new System.Drawing.Point(329, 263);
            this.txtAddProd.Name = "txtAddProd";
            this.txtAddProd.Size = new System.Drawing.Size(100, 20);
            this.txtAddProd.TabIndex = 7;
            // 
            // lblEditProd
            // 
            this.lblEditProd.AutoSize = true;
            this.lblEditProd.Location = new System.Drawing.Point(326, 103);
            this.lblEditProd.Name = "lblEditProd";
            this.lblEditProd.Size = new System.Drawing.Size(76, 13);
            this.lblEditProd.TabIndex = 6;
            this.lblEditProd.Text = "Product name:";
            // 
            // lblEditSupp
            // 
            this.lblEditSupp.AutoSize = true;
            this.lblEditSupp.Location = new System.Drawing.Point(215, 103);
            this.lblEditSupp.Name = "lblEditSupp";
            this.lblEditSupp.Size = new System.Drawing.Size(77, 13);
            this.lblEditSupp.TabIndex = 5;
            this.lblEditSupp.Text = "Supplier name:";
            // 
            // cboEditSupp
            // 
            this.cboEditSupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditSupp.FormattingEnabled = true;
            this.cboEditSupp.Location = new System.Drawing.Point(215, 119);
            this.cboEditSupp.Name = "cboEditSupp";
            this.cboEditSupp.Size = new System.Drawing.Size(96, 21);
            this.cboEditSupp.TabIndex = 4;
            // 
            // txtEditProd
            // 
            this.txtEditProd.Location = new System.Drawing.Point(329, 120);
            this.txtEditProd.Name = "txtEditProd";
            this.txtEditProd.Size = new System.Drawing.Size(100, 20);
            this.txtEditProd.TabIndex = 3;
            // 
            // lblProdTitle
            // 
            this.lblProdTitle.AutoSize = true;
            this.lblProdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdTitle.Location = new System.Drawing.Point(14, 41);
            this.lblProdTitle.Name = "lblProdTitle";
            this.lblProdTitle.Size = new System.Drawing.Size(122, 31);
            this.lblProdTitle.TabIndex = 1;
            this.lblProdTitle.Text = "Products";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 371);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmGeneral";
            this.Text = "Shop Management";
            this.tabControl1.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblProdTitle;
        private System.Windows.Forms.ComboBox cboEditSupp;
        private System.Windows.Forms.TextBox txtEditProd;
        private System.Windows.Forms.Label lblEditProd;
        private System.Windows.Forms.Label lblEditSupp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddProd;
        private System.Windows.Forms.Label lblAddSupp;
        private System.Windows.Forms.ComboBox cboAddProd;
        private System.Windows.Forms.TextBox txtAddProd;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnRemoveProd;
    }
}

