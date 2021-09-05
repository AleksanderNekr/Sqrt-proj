using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Sqrt
{
    public partial class Form1 : Form
    {
        public string NumberText;
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                CultureInfo.GetCultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture =
                CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NumberText = textBox.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var number = Convert.ToDouble(NumberText);
            textBox.Text = Math.Round(Math.Sqrt(number),
                int.Parse(numsAfterDot.Text)).ToString();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }
        private void numsAfterDot_ValueChanged(object sender, EventArgs e)
        {
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (textBox.Text.Contains(',') || textBox.Text.Contains('.') || e.KeyChar != ',');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new CultureInfo[]
            {
                CultureInfo.GetCultureInfo("ru-RU"),
                CultureInfo.GetCultureInfo("en-US")
            };
            comboBox1.DisplayMember = "NativeName";
            comboBox1.ValueMember = "Name";

        }
    }
}
