using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitVendorApp
{
    public partial class paymentform : Form
    {
        public paymentform()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtName.Text} Congratulations! " +
                $"Your Order is Placed.");
            Application.Exit();
        }
    }
}
