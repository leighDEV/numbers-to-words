using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers_to_words
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string text = tbNumbers.Text;
                long num;

                long.TryParse(text, out num);

                string[] words = new string[] { "", "one", "two", "three", "four", "five", "six", "seven",
                "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num > 999)
                {
                    long n = num / 1000;
                    tbWords.Text = tbWords.Text + $"{words[n]} thousand ";
                    num -= n * 1000;
                }

                if (num > 99)
                {
                    long n = num / 100;
                    tbWords.Text = tbWords.Text + $"{words[n]} hundred ";
                    num -= n * 100;
                }

                if (num > 20)
                {
                    long n = num / 10;
                    tbWords.Text = tbWords.Text + $"{words[n + 18]} ";
                    num -= n * 10;
                }

                if (tbNumbers.Text == "0")
                {
                    tbWords.Text = "zero";
                }

                tbWords.Text = tbWords.Text + words[num];
                
            }
            catch (Exception ex)
            {
                tbWords.Text = "Error. Number should be less than trillion.\n";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNumbers.Clear();
            tbWords.Clear();
        }
    }
}
