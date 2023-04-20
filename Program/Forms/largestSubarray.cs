using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class largestSubarray : Form
    {
        public largestSubarray()
        {
            InitializeComponent();
        }

        // This function Prints the starting and ending
        // indexes of the largest subarray with equal
        // number of 0s and 1s. Also returns the size
        // of such subarray.

        private void findSubArray(int[] arr, int n)
        {
            int sum = 0;
            int maxsize = -1, startindex = 0;
            int endindex = 0;

            // Pick a starting point as i
            for (int i = 0; i < n - 1; i++)
            {
                sum = (arr[i] == 0) ? -1 : 1;

                // Consider all subarrays starting from i

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == 0)
                        sum += -1;
                    else
                        sum += 1;

                    // If this is a 0 sum subarray, then
                    // compare it with maximum size subarray
                    // calculated so far

                    if (sum == 0 && maxsize < j - i + 1)
                    {
                        maxsize = j - i + 1;
                        startindex = i;
                    }
                }
            }
            endindex = startindex + maxsize - 1;
            if (maxsize == -1)
                outputLabel.Text = "No such subarray";
            else
                outputLabel.Text = startindex + " to " + endindex;

            
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
            int size = arr.Length;
            findSubArray(arr, size);

        }

        private void largestSubarray_Load(object sender, EventArgs e)
        {

        }
    }
}
