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
                textBox.Text = Math.Round(Math.Sqrt(number), int.Parse(numsAfterDot.Text)).ToString();
            }
            catch (Exception)
            {
                textBox.Text = "Ошибка!";
            }
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
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (textBox.Text.Contains(',') || e.KeyChar != ',');
        }
    }
}
