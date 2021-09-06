using System;
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
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            }

            InitializeComponent();
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

            textBoxRE.Text = Math.Round(double.Parse(Complex.Sqrt(ComplexNum).Real
                .ToString()), int.Parse(numsAfterDot.Text)).ToString();

            textBoxIM.Text = Math.Round(double.Parse(Complex.Sqrt(ComplexNum).Imaginary
                .ToString()), int.Parse(numsAfterDot.Text)).ToString();
        }

        private void ClearButtonRE_Click(object sender, EventArgs e)
        {
            textBoxRE.Text = "0";
        }

        private void ClearButtonIM_Click(object sender, EventArgs e)
        {
            textBoxIM.Text = "0";
        }

        private void textBoxRE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (textBoxRE.Text.Contains('.') || e.KeyChar != '.');
        }

        private void textBoxIM_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && (textBoxIM.Text.Contains('.') || e.KeyChar != '.');
        }

        private void plMinBtnRE_Click(object sender, EventArgs e)
        {
            textBoxRE.Text = (-1 * double.Parse(textBoxRE.Text)).ToString();
        }

        private void plMinBtnIM_Click(object sender, EventArgs e)
        {
            textBoxIM.Text = (-1 * double.Parse(textBoxIM.Text)).ToString();
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
    }
}
