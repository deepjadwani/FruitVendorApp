using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FruitVendorApp
{    
    public partial class Form1 : Form
    {      
        public double kesarQty = 0;
        public double alphonsoQty = 0;
        public double pairyQty = 0;
        public double raspBerryQty = 0;
        public double blackBerryQty = 0;
        public double cherriesQty = 0;
        public double lycheeQty = 0;

        public int kesarPrice = 1100;
        public int alphonsoPrice = 1700;
        public int pairiPrice = 800;
        public int raspBerryPrice = 280;
        public int blackBerryPrice = 95;
        public int cherriesPrice = 180;
        public int lycheePrice = 380;

        public double totalPrice = 0;

        public static Form1 instance;  
        public Form1()
        {
            //dashbord();
            InitializeComponent();
            instance = this;
        }
        public void dashbord()
        {/* if(btnMango.Enabled = false ) */
            //paneld.Dock = DockStyle.Fill;  
            //paneld.Show();
            //    pnlCheckout.Hide();
            
        //panel10.Hide();
        }
        private void btnMango_Click(object sender, EventArgs e)
        {
            pnlMango.Show();
            pnlBerries.Hide();
            pnlCheeries.Hide();
            pnlLychee.Hide();
            panel1.Hide();
            pnlCheckout.Hide();
        }
        private void btnLychee_Click(object sender, EventArgs e)
        {
            pnlLychee.Show();
            pnlMango.Hide();
            pnlBerries.Hide();
            pnlCheeries.Hide();
            panel1.Hide();
            pnlCheckout.Hide();
        }
        private void btnBerries_Click(object sender, EventArgs e)
        {
            pnlBerries.Show();
            pnlLychee.Hide();
            pnlMango.Hide();
            pnlCheeries.Hide();
            panel1.Hide();
            pnlCheckout.Hide();
        }
        private void btnCherries_Click(object sender, EventArgs e)
        {
            pnlCheeries.Show();
            pnlBerries.Hide();
            pnlLychee.Hide();
            pnlMango.Hide();
            panel1.Hide();
            pnlCheckout.Hide();
        }
        private void pnlBerries_Paint(object sender, PaintEventArgs e)
        {
            pnlBerries.Dock = DockStyle.Fill;
            tableLayoutPanel3.Dock = DockStyle.Fill;
        }
        private void pnlLychee_Paint(object sender, PaintEventArgs e)
        {
            pnlLychee.Dock = DockStyle.Fill;
            tableLayoutPanel2.Dock = DockStyle.Fill;
        }
        private void pnlCheeries_Paint(object sender, PaintEventArgs e)
        {
            pnlCheeries.Dock = DockStyle.Fill;
            tableLayoutPanel1.Dock = DockStyle.Fill;
        }
        private void pnlMango_Paint(object sender, PaintEventArgs e)
        {
            pnlMango.Dock = DockStyle.Fill;
            tableLayoutPanel4.Dock = DockStyle.Fill;
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //txtKesar.Text = kesarQty.ToString();
            //txtAlphonso.Text = alphonsoQty.ToString();
            //txtPairy.Text = pairyQty.ToString();    
            //txtRaspBerry.Text = raspBerryQty.ToString();
            //txtBlackBerry.Text = blackBerryQty.ToString();
            //txtCherries.Text = cherriesQty.ToString();
            //txtLychee.Text = lycheeQty.ToString();

            double kesarQty = !string.IsNullOrEmpty(txtKesar.Text) ? Convert.ToDouble(txtKesar.Text) : 0;
            double alphonsoQty = !string.IsNullOrEmpty(txtAlphonso.Text) ? Convert.ToDouble(txtAlphonso.Text) : 0;
            double pairyQty = !string.IsNullOrEmpty(txtPairy.Text) ? Convert.ToDouble(txtPairy.Text) : 0;
            double raspBerryQty = !string.IsNullOrEmpty(txtRaspBerry.Text) ? Convert.ToDouble(txtRaspBerry.Text) : 0;
            double blackBerryQty = !string.IsNullOrEmpty(txtBlackBerry.Text) ? Convert.ToDouble(txtBlackBerry.Text) : 0;
            double cherriesQty = !string.IsNullOrEmpty(txtCherries.Text) ? Convert.ToDouble(txtCherries.Text) : 0;
            double lycheeQty = !string.IsNullOrEmpty(txtLychee.Text) ? Convert.ToDouble(txtLychee.Text) : 0;

            double kesarTotal = kesarPrice * kesarQty;
            double alphonsoTotal = alphonsoPrice * alphonsoQty;
            double pairiTotal = pairyQty * pairiPrice;
            double raspBerryTotal = raspBerryQty * raspBerryPrice;
            double blackBerryTotal = blackBerryQty * blackBerryPrice;
            double cherriesTotal = cherriesQty * cherriesPrice;
            double lycheeTotal = lycheeQty * lycheePrice;

            totalPrice = kesarTotal + alphonsoTotal + pairiTotal + raspBerryTotal + blackBerryTotal + cherriesTotal + lycheeTotal;
            txtTotalPay.Text = totalPrice.ToString();
            
            if (totalPrice > 0)
            {  
                Form1 form = new Form1();
                form.Hide();
                panel2.Hide();
                picMng.Hide();
                panelMenu.Hide();
                pnlCheckout.Dock = DockStyle.Fill;
                pnlCheckout.Show();

                if (lycheeQty > 0)
                {
                    ListViewItem item = new ListViewItem("Lychee 1 pack ( 1 kg)");
                    item.SubItems.Add("₹380");
                    item.SubItems.Add(lycheeQty.ToString());
                    item.SubItems.Add(lycheeTotal.ToString());

                    listView1.Items.Add(item);
                }
                if (cherriesQty > 0)
                {
                    ListViewItem item = new ListViewItem("Cherries 1 pack (approx. 200 gram)");
                    item.SubItems.Add("₹180");
                    item.SubItems.Add(cherriesQty.ToString());
                    item.SubItems.Add(cherriesTotal.ToString());

                    listView1.Items.Add(item);
                }
                if(raspBerryQty > 0)
                {
                    ListViewItem item = new ListViewItem("Raspberry 1 pack (approx. 1 kg)");
                    item.SubItems.Add("₹280");
                    item.SubItems.Add(raspBerryQty.ToString());
                    item.SubItems.Add(raspBerryTotal.ToString());

                    listView1.Items.Add(item);
                }
                if(blackBerryQty > 0)
                {
                    ListViewItem item = new ListViewItem("Black Berry 1 pack (approx. 100 gram)");
                    item.SubItems.Add("₹95");
                    item.SubItems.Add(blackBerryQty.ToString());
                    item.SubItems.Add(blackBerryTotal.ToString());

                    listView1.Items.Add(item);
                }
                if(kesarQty > 0)
                {
                    ListViewItem item = new ListViewItem("Gir Kesar Mango (1 KG)");
                    item.SubItems.Add("₹1100");
                    item.SubItems.Add(kesarQty.ToString());
                    item.SubItems.Add(kesarTotal.ToString());

                    listView1.Items.Add(item);
                }
                if(alphonsoQty > 0)
                {
                    ListViewItem item = new ListViewItem("Alphonso Mango (1 KG)");
                    item.SubItems.Add("₹1700");
                    item.SubItems.Add(alphonsoQty.ToString());
                    item.SubItems.Add(alphonsoTotal.ToString());

                    listView1.Items.Add(item);
                }
                if (pairyQty > 0)
                {
                    ListViewItem item = new ListViewItem("Pairy Mango (1 KG)");
                    item.SubItems.Add("₹800");
                    item.SubItems.Add(pairyQty.ToString());
                    item.SubItems.Add(pairiTotal.ToString());

                    listView1.Items.Add(item);
                }                              
            }
        }
        private void LycheeQtyInc_Click(object sender, EventArgs e)
        {
            lycheeQty++;
            txtLychee.Text = lycheeQty.ToString();

            //if (LycheeQtyInc.Enabled)
            //{
            //    
            //}
            //else if(raspBerryQtyInc.Enabled)
            //{
            //    raspBerryQty++;
            //    txtRaspBerry.Text = raspBerryQty.ToString();
            //} else if (blackBerryQtyInc.Enabled)
            //{
            //    blackBerryPrice++;
            //    txtBlackBerry.Text = blackBerryQty.ToString();
            //}
        }
        private void cherriesQtyInc_Click(object sender, EventArgs e)
        {
            cherriesQty++;
            txtCherries.Text = cherriesQty.ToString();  
        }
        private void raspBerryQtyInc_Click(object sender, EventArgs e)
        {
            raspBerryQty++;
            txtRaspBerry.Text = raspBerryQty.ToString();
        }
        private void blackBerryQtyInc_Click(object sender, EventArgs e)
        {
            blackBerryQty++;
            txtBlackBerry.Text = blackBerryQty.ToString();
        }
        private void PairyQtyInc_Click(object sender, EventArgs e)
        {
            pairyQty++;
            txtPairy.Text = pairyQty.ToString();
        }
        private void KesarQtyInc_Click(object sender, EventArgs e)
        {
            kesarQty++;
            txtKesar.Text = kesarQty.ToString();
        }
        private void AlphonsoQtyInc_Click(object sender, EventArgs e)
        {
            alphonsoQty++;
            txtAlphonso.Text = alphonsoQty.ToString();
        }   
        private void PairyQtyDec_Click(object sender, EventArgs e)
        {
            pairyQty--;
            txtPairy.Text = pairyQty.ToString() ;
            while(pairyQty <= 0) {  pairyQty++; }
        }

        private void KesarQtyDec_Click(object sender, EventArgs e)
        {
            kesarQty--;
            txtKesar.Text = kesarQty.ToString();
            while (kesarQty <= 0)
            {
                kesarQty++;
            }
        }
        private void AlphonsoQtyDec_Click(object sender, EventArgs e)
        {
            alphonsoQty--;
            txtAlphonso.Text = alphonsoQty.ToString();
            while (kesarQty <= 0)
            {
                ++alphonsoQty;
            }
        }
        private void rbtnhome_CheckedChanged(object sender, EventArgs e)
        {            
            if (rbtnhome.Checked )
            {
                AddDeliveryCharge();

            }
           
        }
        private void rbtncollectshop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtncollectshop.Checked)
            {
                RemoveDeliveryCharge();
            }
        }
        private void AddDeliveryCharge()
        {            
            bool found = false;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == "Delivery Charge")
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                
                ListViewItem item = new ListViewItem("Delivery Charge");
                item.SubItems.Add("₹50");
                item.SubItems.Add(" ");
                item.SubItems.Add("₹50");

                listView1.Items.Add(item);

                totalPrice += 50;
                txtTotalPay.Text = totalPrice.ToString();
            }
        }
        private void RemoveDeliveryCharge()
        {
            
            ListViewItem itemToRemove = null;
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.Items[i];
                if (item.Text == "Delivery Charge")
                {
                    itemToRemove = item;
                    break;
                }
            }
            if (itemToRemove != null)
            {
                totalPrice -= 50;
                txtTotalPay.Text = totalPrice.ToString();

                listView1.Items.Remove(itemToRemove);
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (rbtnhome.Checked)
            {
                paymentform pay = new paymentform();
                pay.Show();
                this.Hide();
            }
            else if (rbtncollectshop.Checked) 
            {
                MessageBox.Show($"Your Order is Placed. \n Please Collect it from shop.");
                Application.Exit();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            picm.Dock = DockStyle.Fill;
        }
    }

}

