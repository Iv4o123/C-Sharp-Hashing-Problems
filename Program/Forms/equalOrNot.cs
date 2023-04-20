using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class equalOrNot : Form
    {
        public equalOrNot()
        {
            InitializeComponent();
        }

        public static bool areEqual(int[] arr1, int[] arr2)
        {
            int N = arr1.Length;
            int M = arr2.Length;

            // If lengths of array are not
            // equal means array are not equal
            if (N != M)
                return false;

            // Sort both arrays
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Linearly compare elements
            for (int i = 0; i < N; i++)
                if (arr1[i] != arr2[i])
                    return false;

            // If all elements were same.
            return true;
        }
        private void equalOrNot_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string inputOne = inputTB.Text;
            char[] delimiters = { ',', ' ' }; // comma or space as delimiter
            string[] values = inputOne.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int[] arr1 = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int.TryParse(values[i], out arr1[i]); // or intArray[i] = int.Parse(values[i]);
            }

            string inputTwo = inputTBTwo.Text;
            char[] delimiters2 = { ',', ' ' }; // comma or space as delimiter
            string[] values2 = inputTwo.Split(delimiters2, StringSplitOptions.RemoveEmptyEntries);
            int[] arr2 = new int[values2.Length];

            for (int i = 0; i < values2.Length; i++)
            {
                int.TryParse(values2[i], out arr2[i]); // or intArray[i] = int.Parse(values[i]);
            }

            // Function call
            if (areEqual(arr1, arr2))
               outputLabel.Text = "Yes";
            else
                outputLabel.Text = "No!";
        }
    }
}
