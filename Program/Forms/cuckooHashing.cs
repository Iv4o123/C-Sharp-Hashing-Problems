using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stungata.Forms
{
    public partial class cuckooHashing : Form
    {

        private const int MAXN = 11;
        private const int VER = 2;
        private int[,] hashtable = new int[VER, MAXN];
        private int[] pos = new int[VER];

        public cuckooHashing()
        {
            InitializeComponent();
        }

        private void InitTable()
        {
            for (int j = 0; j < MAXN; j++)
            {
                for (int i = 0; i < VER; i++)
                {
                    hashtable[i, j] = int.MinValue;
                }
            }
        }

        private int Hash(int function, int key)
        {
            switch (function)
            {
                case 1:
                    return key % MAXN;
                case 2:
                    return (key / MAXN) % MAXN;
            }
            return int.MinValue;
        }

        private void Place(int key, int tableID, int cnt, int n)
        {
            if (cnt == n)
            {
                label3.Text = $"{key} unpositioned\nCycle present. REHASH.";
                return;
            }

            for (int i = 0; i < VER; i++)
            {
                pos[i] = Hash(i + 1, key);
                if (hashtable[i, pos[i]] == key)
                {
                    return;
                }
            }

            if (hashtable[tableID, pos[tableID]] != int.MinValue)
            {
                int dis = hashtable[tableID, pos[tableID]];
                hashtable[tableID, pos[tableID]] = key;
                Place(dis, (tableID + 1) % VER, cnt + 1, n);
            }
            else
            {
                hashtable[tableID, pos[tableID]] = key;
            }
        }

        private void PrintTable()
        {
            label3.Text = "Final hash tables:\n";

            for (int i = 0; i < VER; i++, label3.Text += "\n")
            {
                for (int j = 0; j < MAXN; j++)
                {
                    if (hashtable[i, j] == int.MinValue)
                    {
                        label3.Text += "- ";
                    }
                    else
                    {
                        label3.Text += $"{hashtable[i, j]} ";
                    }
                }
            }

            label3.Text += "\n";
        }

        private void Cuckoo(int[] keys, int n)
        {
            InitTable();

            for (int i = 0, cnt = 0; i < n; i++, cnt = 0)
            {
                Place(keys[i], 0, cnt, n);
            }

            PrintTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void checkButton_Click(object sender, EventArgs e)
        {
            string inputOne = inputTB.Text;
            char[] delimiters = { ',', ' ' }; // comma or space as delimiter
            string[] values = inputOne.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int[] keys_1 = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int.TryParse(values[i], out keys_1[i]); // or intArray[i] = int.Parse(values[i]);
            }
            int n = keys_1.Length;

            Cuckoo(keys_1, n);
        }

        
        private void cuckooHashing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputOne = inputTwoTB.Text;
            char[] delimiters = { ',', ' ' }; // comma or space as delimiter
            string[] values = inputOne.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int[] keys_2 = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                int.TryParse(values[i], out keys_2[i]); // or intArray[i] = int.Parse(values[i]);
            }
            int m = keys_2.Length;

            Cuckoo(keys_2, m);
        }
    }
}
