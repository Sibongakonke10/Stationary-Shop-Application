using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stationary_Shop_Application
{
    public partial class Form1 : Form
    {
        decimal rulerCost=2;
        decimal penCost=3.50m;
        decimal pencilCost=2;
        decimal bookCost=5;
        decimal notepadCost=7.5m;
        decimal totalAmt;
        public Form1()
        {
            InitializeComponent();
        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            if((rulersBox.Text==""))
            {
                MessageBox.Show("Rulers cannot be empty");
            }
            if ((pensBox.Text == ""))
            {
                MessageBox.Show("Pens cannot be empty");
            }
            if ((pencilsBox.Text == ""))
            {
                MessageBox.Show("Pencils cannot be empty");
            }
            if ((booksBox.Text == ""))
            {
                MessageBox.Show("Books cannot be empty");
            }
            if ((noteBox.Text == ""))
            {
                MessageBox.Show("Notepads cannot be empty");
            }

            else
            {
                try
                {
                    totalAmt = (rulerCost * decimal.Parse(rulersBox.Text)) + (penCost * decimal.Parse(pensBox.Text)) + (pencilCost * decimal.Parse(pencilsBox.Text)) + (bookCost * decimal.Parse(booksBox.Text)) + (notepadCost * decimal.Parse(noteBox.Text));
                    amountBox.Text = totalAmt.ToString("C2");
                }
                catch
                {
                    MessageBox.Show("Please enter Valid Values");
                }
                
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            rulersBox.Text = " ";
            pensBox.Text = " ";
            pencilsBox.Text = " ";
            booksBox.Text = " ";
            noteBox.Text = " ";
            amountBox.Text = " ";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
