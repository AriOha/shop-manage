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
    public partial class SupplierForm : UserControl
    {
        Supplier supplier;
        public delegate void SaveButtonClickEvent(object sender, EventArgs e);
        public event SaveButtonClickEvent OnSaveButtonClickEvent;
        public delegate void ClearButtonClickEvent(object sender, EventArgs e);
        public event ClearButtonClickEvent OnClearButtonClickEvent;
        public SupplierForm()
        {
            InitializeComponent();
            supplier = new Supplier();
        }

        public void Clear()
        {
            supplier.Clear();
            UpdateViewInputs();
        }

        //updates the current inputs from the supplier object
        private void UpdateViewInputs()
        {
            txtName.Text = supplier.Name;
            txtAddress.Text = supplier.Address;
            txtPhone.Text = supplier.Phone;
            txtEmail.Text = supplier.Email;
        }

        //Refresh the data of the object according the current inputs
        public void RefreshData()
        {
            supplier.Name = txtName.Text;
            supplier.Address = txtAddress.Text;
            supplier.Phone = txtPhone.Text;
            supplier.Email = txtEmail.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            if (OnClearButtonClickEvent != null)
            {
                OnClearButtonClickEvent(this, e);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (OnSaveButtonClickEvent != null)
            {
                OnSaveButtonClickEvent(this, e);
            }
        }

        public Supplier Supplier
        {
            get { return supplier; }
            set
            {
                supplier.Id = value.Id;
                supplier.Name = value.Name;
                supplier.Address = value.Address;
                supplier.Phone = value.Phone;
                supplier.Email = value.Email;
                UpdateViewInputs();
            }
        }

    }
}
