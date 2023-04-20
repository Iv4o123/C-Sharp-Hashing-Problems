using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class subsequence : Form
    {
        public subsequence()
        {
            InitializeComponent();
        }

        public static int LongestSubsequence(int[] a, int n)
        {

            // initialize x to the first element of the array;
            int x = a[0];

            // initialize count to Zero
            int count = 0, y = 0;

            // iterate for all elements
            for (int i = 0; i < n; i++)
            {
                if (a[i] == (x + y))
                {
                    count++;
                    y++;
                }
            }
            return count;
        }
        private void subsequence_Load(object sender, EventArgs e)
        {

           

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string inputOne = inputTB.Text;
            char[] delimiters = { ',', ' ' }; // comma or space as delimiter
            string[] values = inputOne.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int[] a = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int.TryParse(values[i], out a[i]); // or intArray[i] = int.Parse(values[i]);
            }
            int n = a.Length;
            outputLabel.Text = Convert.ToString(LongestSubsequence(a, n));
        }
    }
}
