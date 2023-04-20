using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class recaman : Form
    {
        public recaman()
        {
            InitializeComponent();
        }

        private void recamans(int n)
        {
            // Create an array to store terms
            int[] arr = new int[n];

            // First term of the sequence is always 0
            arr[0] = 0;
            Console.Write(arr[0] + " ,");

            // Fill remaining terms using recursive
            // formula.
            for (int i = 1; i < n; i++)
            {
                int curr = arr[i - 1] - i;
                int j;
                for (j = 0; j < i; j++)
                {
                    // If arr[i-1] - i is negative or
                    // already exists.
                    if ((arr[j] == curr) || curr < 0)
                    {
                        curr = arr[i - 1] + i;
                        break;
                    }
                }



                arr[i] = curr;
                outputLabel.Text = arr[i] + ", ";

            }
        }

        private void recaman_Load(object sender, EventArgs e)
        {

        }

        
        

        private void checkButton_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(textBox1.Text, out n) || n < 1)
            {
                MessageBox.Show("Please enter a valid positive integer.");
                return;
            }

            int[] seq = new int[n];
            bool[] used = new bool[n * 2];

            seq[0] = 0;
            used[0] = true;

            for (int i = 1; i < n; i++)
            {
                int prev = seq[i - 1];
                int next = prev - i;
                if (next < 0 || used[next])
                {
                    next = prev + i;
                }
                seq[i] = next;
                used[next] = true;
            }


        }

        private void outputLabel_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_SizeChanged(object sender, EventArgs e)
        {
            outputLabel.AutoSize = false;
            outputLabel.MaximumSize = new Size(outputLabel.Width, 0);
            outputLabel.Height = TextRenderer.MeasureText(outputLabel.Text, outputLabel.Font, outputLabel.MaximumSize,
                TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl).Height;
        }
    }
}
