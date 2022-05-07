using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace numbers_to_words
{
    /// <summary>
    /// A numbers (9999) to words converter using
    /// C# Windows Forms application
    /// </summary>
    public partial class Form1 : MaterialForm
    {
        #region Constructors
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink900, Primary.Pink800, Primary.Pink500, Accent.Pink200, TextShade.WHITE);
        }
        #endregion

        /// <summary>
        /// Converting the numbers to words
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                tbWords.ResetText();
                string text = tbNumbers.Text;
                long num;

                long.TryParse(text, out num);

                string[] words = new string[] { "", "one", "two", "three", "four", "five", "six", "seven",
                "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num > 999 && num < 10000)
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
            catch
            {
                tbWords.Text = "Error. Number should be less than a 10000.\n";
            }
        }
    }
}
