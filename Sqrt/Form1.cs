using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqrt
{
    public partial class Form1 : Form
    {
        public string Sqrt;
        public string Num;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Num = textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sn1, res;
            sn1 = Convert.ToDouble(Num);
            res = Math.Sqrt(sn1);
            textBox1.Text = res.ToString();

        }

    }
}
