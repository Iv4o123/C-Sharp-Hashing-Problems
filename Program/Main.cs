using Stungata.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stungata
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Задава трудността на Лесно при начално стартиране
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void difficultyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            problemOne probOne = new problemOne();
            probOne.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cuckooHashing cucko = new cuckooHashing();
            cucko.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            findPairs fp = new findPairs();
            fp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            recaman rec = new recaman();
            rec.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            equalOrNot eorn = new equalOrNot();
            eorn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            largestSubarray lsubarray = new largestSubarray();
            lsubarray.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            subarrayWithSum subarratWith0Sum = new subarrayWithSum();
            subarratWith0Sum.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            subsequence sub = new subsequence();
            sub.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            divisible div = new divisible();
            div.Show();
        }
    }
}
