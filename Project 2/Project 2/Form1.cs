using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Project_2
{
    public partial class Form1 : Form
    {
        string Foods;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFood_TextChanged(object sender, EventArgs e)
        {
            
            Foods = txtFood.Text;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            lstFoods.Items.Add(txtFood.Text);
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            string lstFoodItems = lstFoods.Items.ToString();

            StreamWriter outputFile;
            outputFile = File.CreateText(@"fooditems.txt");
            outputFile.WriteLine(lstFoodItems);
            outputFile.Close();

            MessageBox.Show("Information Saved!");

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstFoods.SelectedIndex;
            if (selectedIndex >= 0)
                lstFoods.Items.RemoveAt(selectedIndex);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

            string[] fileContents = File.ReadAllLines("fooditems.txt");
            lstFoods.Items.AddRange(fileContents);
            
        }
    }
}
