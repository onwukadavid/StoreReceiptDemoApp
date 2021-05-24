using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreReceiptApp
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

            Receipt a;

        private void btnCreate_Click(object sender, EventArgs e)
        {

            a = new Receipt();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            a.Id = int.Parse(txtId.Text);
            a.Name = txtName.Text;
            a.Product = txtProduct.Text;
            a.Price= decimal.Parse(txtPrice.Text);
        //  a.Balance = decimal.Parse(txtBalance.Text);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = a.Id.ToString();
            txtName.Text = a.Name;
            txtProduct.Text = a.Product;
            txtPrice.Text = a.Price.ToString();
            txtBalance.Text = a.Balance.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtProduct.Clear();
            txtPrice.Clear();
            txtPay.Clear();
            txtBalance.Text = "";
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            a = null; 
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();       // invokes garbage collection
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Receipt b;
            b = new Receipt();
           // a = b;
        }

        private void btnGetGeneration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GC.GetGeneration(a).ToString());
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            a.pay(decimal.Parse(txtPay.Text));
        }
    }
}
