using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirstMSTestProject
{
    public partial class frmCalculateAmount : Form
    {
        public frmCalculateAmount()
        {
            InitializeComponent();
        }

        // create a methode to calculate Final amount after Discount amount

        public void CalculateAmountAfterDiscount()
        {

            txtFinalAmount.Text = ((txtTotalAmount.Text == "" ? 0 : Convert.ToDecimal(txtTotalAmount.Text)) - (txtDiscountAmount.Text == "" ? 0 : Convert.ToDecimal(txtDiscountAmount.Text))).ToString();


        }


        // only can input number with decimal. characters are not allowed.

        private void Controls_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (Char)Keys.Enter)
                SendKeys.Send("{TAB}");
            else
            {
                const char Delete = (char)8;
                e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != '.';
            }
        }


        // Exit application

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Execute CalculateAmountAfterDiscount methode on text change event.


        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateAmountAfterDiscount();
        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateAmountAfterDiscount();
        }


        //clear text box values and give cursor to Firts Text Box

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotalAmount.Text = String.Empty;
            txtDiscountAmount.Text = String.Empty;
            txtFinalAmount.Text = String.Empty;
            txtTotalAmount.Focus();

        }
    }
}
