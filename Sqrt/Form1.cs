using System;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;
using Sqrt.Properties;

namespace Sqrt
{
    public partial class SquareRootProgram : Form
    {
        public SquareRootProgram()
        {
            // Checking for the presence of a language group
            if (!string.IsNullOrEmpty(Settings.Default.Language))
            {
                // Loading default language
                Thread.CurrentThread.CurrentUICulture =
                    CultureInfo.GetCultureInfo(Settings.Default.Language);
                // Applying the separator style - dots
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Loading languages
            comboBox1.DataSource = new[]
                                   {
                                       CultureInfo.GetCultureInfo("ru-RU"),
                                       CultureInfo.GetCultureInfo("en-US"),
                                       CultureInfo.GetCultureInfo("es-ES"),
                                       CultureInfo.GetCultureInfo("zh")
                                   };

            comboBox1.DisplayMember = "NativeName";
            comboBox1.ValueMember   = "Name";

            // Applying language
            if (!string.IsNullOrEmpty(Settings.Default.Language)) comboBox1.SelectedValue = Settings.Default.Language;
        }

        // Saving language
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Language = comboBox1.SelectedValue.ToString();
            Settings.Default.Save();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Close();
            Process.Start(Application.StartupPath + "\\Sqrt.NET.exe");
        }

        // Calculation of arithmetic and complex roots
        private void ComplexSqrt_Click(object sender, EventArgs e)
        {
            // Checking for an empty input string
            double ConvertTextbox(string text)
            {
                return text == "" ? 0.0 : double.Parse(text);
            }

            // Reading the real and complex parts of a number
            double numRe = ConvertTextbox(textBoxRE.Text);
            double numIm = ConvertTextbox(textBoxIM.Text);

            // Creating a complex number
            Complex complexNum = new Complex(numRe, numIm);

            // Square root function and rounding a number
            string GetSqrt(double number)
            {
                return Math.Round(number, int.Parse(DecPointDigitsCount.Text))
                           .ToString($"F{DecPointDigitsCount.Text}");
            }

            // Derivation of the real and complex parts of a number
            textBoxRE.Text = GetSqrt(Complex.Sqrt(complexNum).Real);
            textBoxIM.Text = GetSqrt(Complex.Sqrt(complexNum).Imaginary);
        }

        // Clear text buttons
        private void ClearButtonRE_Click(object sender, EventArgs e)
        {
            textBoxRE.Text = @"0";
        }

        private void ClearButtonIM_Click(object sender, EventArgs e)
        {
            textBoxIM.Text = @"0";
        }

        // Function that prevents "bad input":
        // only numbers are accepted as input,
        // it is possible to press the "Backspace" key,
        // and check for the number of separators (only 1)
        private static bool PreventBadText(string text, char key)
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

        // Function that reverses the sign of a number
        private string ChangeSign(string text)
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

        // Functions for copying numbers using buttons
        private void CopyBtnRE_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBoxRE.Text);
        }

        private void CopyBtnIM_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBoxIM.Text);
        }

        // Functions adding operators for analytic roots
        private void Button2_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"x";
        }

        private void SinBtn_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"Sin(x)";
        }

        private void ClearBtnAnalytic_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text = "";
        }

        private void CosBtn_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"Cos(x)";
        }

        private void TanBtn_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"Tan(x)";
        }

        private void CotBtn_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"Cot(x)";
        }

        private void Pow2Btn_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"²";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"+";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"-";
        }

        private void BtnLeftBr_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"(";
        }

        private void BtnRightBr_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @")";
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"×";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text += @"/";
        }

        private void AnalyticSqrt_Click(object sender, EventArgs e)
        {
            TextBoxAnalityc.Text =
                TextBoxAnalityc.Text == @"(Sin(x))²"
                    ? "±Sin(x)"
                    : TextBoxAnalityc.Text == @"(Cos(x))²"
                        ? "±Cos(x)"
                        : TextBoxAnalityc.Text == @"(Tan(x))²"
                            ? "±Tan(x)"
                            : TextBoxAnalityc.Text == @"(Cot(x))²"
                                ? "±Cot(x)"
                                : TextBoxAnalityc.Text == @"x²" || TextBoxAnalityc.Text == @"(x)²"
                                    ? "±x"
                                    : TextBoxAnalityc.Text == @"(Sin(x))²×(Cos(x))²"
                                   || TextBoxAnalityc.Text == @"(Sin(x)×Cos(x))²"
                                   || TextBoxAnalityc.Text == @"(Cos(x)×(Sin(x))²"
                                   || TextBoxAnalityc.Text == @"(Cos(x))²×(Sin(x))²"
                                        ? "Sin(x)×Cos(x)"
                                        : !TextBoxAnalityc.Text.Contains('√')
                                            ? $"√{TextBoxAnalityc.Text}"
                                            : TextBoxAnalityc.Text;
        }
    }
}