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

        /// <summary>
        ///updates the current inputs from the supplier object
        /// </summary>
        private void UpdateViewInputs()
        {
            txtName.Text = supplier.Name;
            txtAddress.Text = supplier.Address;
            txtPhone.Text = supplier.Phone;
            txtEmail.Text = supplier.Email;
        }

        /// <summary>
        /// Refresh the data of the object according the current inputs
        /// </summary>
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

        /// <summary>
        /// triggers save button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (value != null)
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

        /// <summary>
        /// if the form is not fully filled, the Save & clear button will be disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void isFormEmpty(object sender, EventArgs e)
        {
            btnSave.Enabled = btnClear.Enabled =
                !(Validation.ValidateIfEmptyOrWhiteSpace(txtName.Text) ||
                Validation.ValidateIfEmptyOrWhiteSpace(txtAddress.Text) ||
                Validation.ValidateIfEmptyOrWhiteSpace(txtPhone.Text) ||
                Validation.ValidateIfEmptyOrWhiteSpace(txtEmail.Text));
            //validating at least 1 input to enable the clear button
            btnClear.Enabled = (
                !string.IsNullOrEmpty(txtName.Text) ||
                !string.IsNullOrEmpty(txtAddress.Text) ||
                !string.IsNullOrEmpty(txtPhone.Text) ||
                !string.IsNullOrEmpty(txtEmail.Text));
        }

        /// <summary>
        /// Getter for btnSave enabled status
        /// </summary>
        public bool isBtnEnabled
        {
            get => btnSave.Enabled;
        }
    }
}
