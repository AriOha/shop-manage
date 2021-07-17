﻿using System;
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
    public partial class CustomerForm : UserControl
    {
        Customer customer;
        public delegate void SaveButtonClickEvent(object sender, EventArgs e);
        public event SaveButtonClickEvent OnSaveButtonClickEvent;
        public delegate void ClearButtonClickEvent(object sender, EventArgs e);
        public event ClearButtonClickEvent OnClearButtonClickEvent;
        public CustomerForm()
        {
            InitializeComponent();
            customer = new Customer();
        }
        public void Clear()
        {
            customer.Clear();
            UpdateViewInputs();
        }

        //updates the current inputs from the customer object
        private void UpdateViewInputs()
        {
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;

        }

        //Refresh the data of the object according the current inputs
        public void RefreshData()
        {
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
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

        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (value != null)
                {
                    customer.Id = value.Id;
                    customer.FirstName = value.FirstName;
                    customer.LastName = value.LastName;
                    UpdateViewInputs();
                }
            }
        }

        private void uc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }
    }
}
