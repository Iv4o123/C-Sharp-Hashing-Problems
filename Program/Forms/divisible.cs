using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class divisible : Form
    {
        public divisible()
        {
            InitializeComponent();
        }

        static int longestSubarrWthSumDivByK(int[] arr, int N,
                                         int k)
        {
            int maxl = 0;
            for (int i = 0; i < N; i++)
            {
                int sum1 = 0;
                for (int j = i; j < N; j++)
                {
                    sum1 += arr[j];
                    if (sum1 % k == 0)
                        maxl = Math.Max(maxl, j - i + 1);
                }
            }

            return maxl;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void divisible_Load(object sender, EventArgs e)
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
            int n = arr.Length;
            int k = Convert.ToInt32(textBox1.Text);

           outputLabel.Text = "Length = " + longestSubarrWthSumDivByK(arr, n, k);

        }
    }
}
