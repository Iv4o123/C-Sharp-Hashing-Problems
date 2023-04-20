using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class subarrayWithSum : Form
    {
        public subarrayWithSum()
        {
            InitializeComponent();
        }

        static int maxLen(int[] arr, int N)
        {
            int max_len = 0;

            // Pick a starting point
            for (int i = 0; i < N; i++)
            {

                // Initialize curr_sum
                // for every starting point
                int curr_sum = 0;

                // try all subarrays
                // starting with 'i'
                for (int j = i; j < N; j++)
                {
                    curr_sum += arr[j];

                    // If curr_sum becomes 0,
                    // then update max_len
                    if (curr_sum == 0)
                        max_len = Math.Max(max_len,
                                           j - i + 1);
                }
            }
            return max_len;
        }

        private void subarrayWithSum_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string inputOne = inputTB.Text;
            char[] delimiters = { ',', ' ' }; // comma or space as delimiter
            string[] values = inputOne.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int.TryParse(values[i], out arr[i]); // or intArray[i] = int.Parse(values[i]);
            }
            int N = arr.Length;

            // Function call
            outputLabel.Text = "Length of the longest 0 sum " + "subarray is " + maxLen(arr, N);

            
        }
    }
}
