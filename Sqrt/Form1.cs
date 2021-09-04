using System;
using System.Globalization;
using System.Windows.Forms;

namespace Sqrt
{
    public partial class Form1 : Form
    {
        public string SqrtSimple;
        public string NumberText;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NumberText = textBox.Text;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var number = Convert.ToDouble(NumberText);
                var result = Math.Sqrt(number);
                textBox.Text = result.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                textBox.Text = "Введите число, не строку!";
            }
            

        }

    }
}
