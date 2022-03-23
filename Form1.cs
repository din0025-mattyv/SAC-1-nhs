using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SofDev_SAC_task_ONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SingPriceCalc()
        {
            //create global so they can be accessed through the whole code
            decimal total = 0M;
            decimal bookAge = 0M;
            decimal willPay = 0M;
            decimal currVal = 0M;


            //check the up/down box contains a valid value
            if(updAge.Value == 0)
            {
                lblAgeErr.Text = "Please enter a value, your device's age cannot be 0.";
            }
            else
            {
                bookAge = updAge.Value;
            }
            

            //set percentage depreciation to a decimal constant so all values can be multiplied
            decimal percentDep = 0.2M;
            
            
            bool parseYes = decimal.TryParse(txtPaidVal.Text, out decimal bookPaid);
            
            if (parseYes == true&bookPaid != 0&bookPaid>0)
            {
                
                currVal = bookPaid * percentDep * bookAge;
               
            }
            else
            {
                //prompt user to input only a numeric value with error message
                lblErr.Text = "Please input only a numeric value greater than 0";

            }
            //ensures the depreciation isn't greater than the original price
            //OR bookAge isn't greater than five

            if (currVal > bookPaid | bookAge > 5)
            {
                willPay = 0M;
                lblSingPrice.Text = willPay.ToString();
            }
            else
            {
                willPay = bookPaid - currVal;
                lblSingPrice.Text = willPay.ToString();


            }
            
            //calculate total of all values so far entered
            total = willPay + total;
            lblCollectPrice.Text = total.ToString();


        }
        private void updPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SingPriceCalc();

        }

        private void btnEndQuote_Click(object sender, EventArgs e)
        {
            //reset all text on Form1
            lblCollectPrice.Text = "---";
            lblSingPrice.Text = "---";

            lblAgeErr.Text = "---";
            lblErr.Text = "---";


        }
    }
}
