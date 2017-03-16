using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void FirstForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hope you are having fun! With GIT");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmount;
            double percent;
            double ans;

            while (double.TryParse(txtPurchase.Text, out purchaseAmount) == false)
            {
                MessageBox.Show("Value entered must be numeric");
                txtPurchase.Text = "0.0";
                //txtPurchase.Clear();
                txtPurchase.Focus(); //Places the cursor inside the txtPurchase label
            }

            inValue = lblTaxPercent.Text;
            inValue = inValue.Remove(inValue.Length - 1, 1);
            percent = double.Parse(inValue) / 100;
            ans = (purchaseAmount * percent) + purchaseAmount;
            txtTotalDue.Text = string.Format("{0:C}", ans);
        }
    }
}
