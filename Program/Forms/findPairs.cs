using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class findPairs : Form
    {
        public findPairs()
        {
            InitializeComponent();
        }

        
        private void findPairs_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Get the input array
            string[] inputArray = inputTB.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Convert the input array to integers
            int[] array = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (!int.TryParse(inputArray[i], out array[i]))
                {
                    MessageBox.Show("Invalid input array");
                    return;
                }
            }

            // Get the value of k
            int k;
            if (!int.TryParse(textBox1.Text, out k))
            {
                MessageBox.Show("Invalid value of k");
                return;
            }

            
            string output = "";
            // Consider each and every pair
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    // Print if their modulo equals to k
                    if (i != j && array[i] % array[j] == k)
                    {
                        output += "(" + array[i] + ", "
                                    + array[j] + ")" + " ";
                        
                        outputLabel.Text = output;
                    }
                }
            }

            
        }
    }
    
}
