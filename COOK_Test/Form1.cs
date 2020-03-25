using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COOK_Test
{
    public partial class Form1 : Form

    {
        // associative array to simuulate database
        string[] postcodes = { "TN9", "TN9 1AP", "TN8", "TN1", "TN11", "TN2", "TN10", "TN13", "TN14", "TN15", "ME", "ME10", "ME10 3", "IV" };
        string[] deliveryOptions = { "Delivery from Warehouse", "No Deliveries", "Delivery from Warehouse", "Delivery from Warehouse", "Van Delivery, Collect from Tunbridge Wells", "Van Delivery, Collect from Tunbridge Wells", "Van Delivery", "Delivery from Sevenoaks, Collect from Sevenoaks", "Delivery from Sevenoaks, Collect from Sevenoaks", "Collect from Sevenoaks", "No Deliveries", "Collect from Kitchen", "Collect from Kitchen, Delivery from Sittingbourne", "No Deliveries" };

        string currentOption = "";
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void getData(string input)
        {

            currentOption = "Delivery By Courier";

            for(int i = 0; i < postcodes.Length; i++)
            {
                if (input.ToUpper().Contains(postcodes[i]))
                {
                    currentOption = deliveryOptions[i];
                }
            }

            deliveryTextBox.Text = currentOption;

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            getData(postcodeTextBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
