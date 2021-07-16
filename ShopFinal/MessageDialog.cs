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
    public partial class MessageDialog : Form
    {
        //static MessageDialog message;

        public MessageDialog()
        {
            InitializeComponent();
        }

        public MessageDialog(string title, string description)
        {
            InitializeComponent();

            this.Text = title;
            this.lblMessage.Text = description;
        }


    }
    public static class MessageHandler
    {
        public static DialogResult Show(string title, string description)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new MessageDialog(title, description))
            {
                return form.ShowDialog();
            }
        }
    }

}