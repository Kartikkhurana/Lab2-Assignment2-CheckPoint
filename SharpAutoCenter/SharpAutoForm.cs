using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 *  App Name: SharpAutoCenter
 *  Author : KARTIK KHURANA
 *  StudentId:200331395
 *  Date:   2017-02-12
 *  Description : To determine the total amount due for the purchase of the vehicle based 
     * on what the users want
     * or trade in value       
     */
namespace SharpAutoCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //when user clicks on the about menuitem
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle");
        }
        //exiting the app
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //calculating the price of both the group boxes
        private double _CalculatePrice()
        {
            double _Amountadded = 0;
            if (Stereosystem.Checked)
            {
                _Amountadded = _Amountadded +425.76;
            }

            if (Leatherinterior.Checked)
            {
                _Amountadded = _Amountadded + 987.41;
            }

            if (Computernavigation.Checked)
            {
                _Amountadded = _Amountadded + 1741.23;
            }
            if (Pearlized.Checked)
            {
                _Amountadded = _Amountadded + 345.72;
            }
            if (Customizeddetailing.Checked)
            {
                _Amountadded = _Amountadded + 599.99;
            }
            return _Amountadded;
        }

        //funvtion of the clear button
        private void button2_Click(object sender, EventArgs e)
        {
            BasePrice.Text = "";
            AdditionalOptions.Text = "";
            SubTotal.Text = "";
            SalesTax.Text = "";
            Total.Text = "";
            TradeInAllowance.Text = "0";  //trade in allowance property set to zero
            AmountDue.Text = "";
            Standard.Checked = true;      //standard radio button set to default
            Stereosystem.Checked = false;
            Leatherinterior.Checked = false;
            Computernavigation.Checked = false;

        }

        //exiting the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //click event handling of the menu items
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
        }
        // function of the calculate button
        private void Calculate_Click(object sender, EventArgs e)
        {
            double _subtotal = double.Parse(BasePrice.Text) + _CalculatePrice();
            SubTotal.Text = _subtotal.ToString("");
            double _saleTax = _subtotal * 0.13;
            SalesTax.Text = _saleTax.ToString("");

            double _total = _subtotal * 1.13;
            Total.Text = _total.ToString("");
            double _amountDue = _total - double.Parse(TradeInAllowance.Text);
            AmountDue.Text = _amountDue.ToString("");
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
