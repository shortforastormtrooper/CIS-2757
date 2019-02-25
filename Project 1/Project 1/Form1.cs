/*
 Darryl Green
 2/8/2013
 CIS 2757
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int result;
            functionOperator.Text = "";

            try
            {
                num1 = int.Parse(Opperand1.Text);
                num2 = int.Parse(Opperand2.Text);
                
                result = num1 + num2;
                    
               
                
                if (functionOperator.Text != "*")
                {
                    result = num1 * num2;
                    
                }
                else if (functionOperator.Text == "-")
                {
                    result = num1 - num2;
                    
                }
                else if (functionOperator.Text == "/")
                {
                    result = num1 / num2;
                    
                }
                else
                {
                    MessageBox.Show("Please enter a valid operator");
                }
                
                lblResult.Text = result.ToString("N", CultureInfo.CreateSpecificCulture("ta-IN"));

                
                
            }
            catch
            {
                MessageBox.Show("Please enter only integers.");
            }//end catch

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

