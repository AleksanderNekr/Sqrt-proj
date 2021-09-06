﻿using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Sqrt
{
    public partial class Form1 : Form
    {
        public string NumberText;
        public Form1()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                    CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture =
                    CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NumberText = textBox.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var number = NumberText == "" ? 0.0 : Convert.ToDouble(NumberText);
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
                CultureInfo.GetCultureInfo("en-US"),
                CultureInfo.GetCultureInfo("es-ES"),
                CultureInfo.GetCultureInfo("zh"),
            };
            comboBox1.DisplayMember = "NativeName";
            comboBox1.ValueMember = "Name";
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                comboBox1.SelectedValue = Properties.Settings.Default.Language;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Properties.Settings.Default.Save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(popuplang.ChangeLangRequest, popuplang.ChangeTitle, MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComplexSqrt_Click(object sender, EventArgs e)
        {
            var NumRE = textBoxRE.Text == "" ? 0.0 : double.Parse(textBoxRE.Text);
            var NumIM = textBoxIM.Text == "" ? 0.0 : double.Parse(textBoxIM.Text);
            var ComplexNum = new Complex(NumRE, NumIM);
            textBoxRE.Text = Complex.Sqrt(ComplexNum).Real.ToString();
            textBoxIM.Text = Complex.Sqrt(ComplexNum).Imaginary.ToString();
        }

        private void TextBoxRE_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxIM_TextChanged(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClearButtonRE_Click(object sender, EventArgs e)
        {
            textBoxRE.Text = "0";
        }

        private void ClearButtonIM_Click(object sender, EventArgs e)
        {
            textBoxIM.Text = "0";
        }
    }
}
