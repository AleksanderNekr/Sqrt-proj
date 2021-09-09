using System;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;

namespace Sqrt
{
    public partial class SquareRootProgram : Form
    {
        public string NumberText;
        public SquareRootProgram()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                    CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            }
            InitializeComponent();
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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Close();
            Process.Start(Application.StartupPath + "\\Sqrt.NET.exe");
        }

        private void ComplexSqrt_Click(object sender, EventArgs e)
        {
            double ConvertTextbox(string text) => text == "" ? 0.0 : double.Parse(text);

            double NumRE = ConvertTextbox(textBoxRE.Text);
            double NumIM = ConvertTextbox(textBoxIM.Text);
            Complex ComplexNum = new Complex(NumRE, NumIM);

            string GetSqrt(double number)
            {
                return Math.Round(number, int.Parse(DecPointDigitsCount.Text))
                    .ToString($"F{DecPointDigitsCount.Text}");
            }
            textBoxRE.Text = GetSqrt(Complex.Sqrt(ComplexNum).Real);
            textBoxIM.Text = GetSqrt(Complex.Sqrt(ComplexNum).Imaginary);
        }

        private void ClearButtonRE_Click(object sender, EventArgs e) => textBoxRE.Text = "0";

        private void ClearButtonIM_Click(object sender, EventArgs e) => textBoxIM.Text = "0";

        public bool PreventBadText(string text, char key)
        {
            return !(char.IsDigit(key) || key == 8 || !text.Contains('.') && key == '.');
        }

        private void TextBoxRE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = PreventBadText(textBoxRE.Text, e.KeyChar);
        }

        private void TextBoxIM_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = PreventBadText(textBoxIM.Text, e.KeyChar);
        }

        public string ChangeSign(string text)
        {
            return (-1 * double.Parse(text)).ToString($"F{DecPointDigitsCount.Text}");
        }

        private void PlusMinusBtnRE_Click(object sender, EventArgs e)
        {
            textBoxRE.Text = ChangeSign(textBoxRE.Text);
        }

        private void PlusMinusBtnIM_Click(object sender, EventArgs e)
        {
            textBoxIM.Text = ChangeSign(textBoxIM.Text);
        }

        private void CopyBtnRE_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBoxRE.Text);
        }

        private void CopyBtnIM_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBoxIM.Text);
        }
    }
}