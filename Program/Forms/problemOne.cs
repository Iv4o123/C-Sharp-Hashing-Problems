using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class problemOne : Form
    {
        public problemOne()
        {
            InitializeComponent();
        }

        static bool isSubset(int[] arr1, int[] arr2, int m,
                         int n)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    if (arr2[i] == arr1[j])
                        break;

                /* If the above inner loop
                was not broken at all then
                arr2[i] is not present in
                arr1[] */
                if (j == m)
                    return false;
            }

            /* If we reach here then all
            elements of arr2[] are present
            in arr1[] */
            return true;
        }

        private void problemOne_Load(object sender, EventArgs e)
        {
            
            
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            string inputOne = arrayOneTB.Text;
            char[] delimiters = { ',', ' ' }; // comma or space as delimiter
            string[] values = inputOne.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int[] arr1 = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int.TryParse(values[i], out arr1[i]); // or intArray[i] = int.Parse(values[i]);
            }

            string inputTwo = arrayTwoTB.Text;
            char[] delimitersTwo = { ',', ' ' }; // comma or space as delimiter
            string[] valuesTwo = inputTwo.Split(delimitersTwo, StringSplitOptions.RemoveEmptyEntries);
            int[] arr2 = new int[valuesTwo.Length];

            for (int i = 0; i < valuesTwo.Length; i++)
            {
                int.TryParse(valuesTwo[i], out arr2[i]); // or intArray[i] = int.Parse(values[i]);
            }

            int m = arr1.Length;
            int n = arr2.Length;

            if (isSubset(arr1, arr2, m, n))
                outputLabel.Text = "Array 2 is subset"
                                  + " of Array 1 ";
            else
                outputLabel.Text = "Array 2 is not a "
                                  + "subset of Array 1";
        }

        private void arrayOneTB_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
