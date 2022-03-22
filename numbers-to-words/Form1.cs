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
                int i = 1;

                string words = tbxNumbers.Text;
                int num;

                if (int.TryParse(words, out num))
                {
                    while (i > 0)
                    {
                        if (num.Equals(0))
                        {
                            lblText.Text = "zero";
                        }
                        if (num > 9999)
                        {
                            lblText.Text = "Error. Number should be less than 10000.\n";
                            continue;
                        }

                        lblText.Text = Converting(num);
                        i++;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxNumbers.Clear();
        }

        private string Converting(int num)
        {
            string[] words = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", 
                "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (num > 999)
            {
                int n = num / 1000;
                return $"{words[n]} thousand ";
                num -= n * 1000;
            }

            if (num > 99)
            {
                int n = num / 100;
                return $"{words[n]} hundred ";
                num -= n * 100;
            }

            if (num > 20)
            {
                int n = num / 10;
                return $"{words[n + 18]} ";
                num -= n * 10;
            }
            return words[num];
        }
    }
}
