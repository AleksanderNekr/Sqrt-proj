
namespace Sqrt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.SQRT = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numsAfterDot = new System.Windows.Forms.NumericUpDown();
            this.ComplexSqrt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRE = new System.Windows.Forms.TextBox();
            this.ClearButtonRE = new System.Windows.Forms.Button();
            this.textBoxIM = new System.Windows.Forms.TextBox();
            this.ClearButtonIM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numsAfterDot)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox.Name = "textBox";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // SQRT
            // 
            resources.ApplyResources(this.SQRT, "SQRT");
            this.SQRT.Name = "SQRT";
            this.SQRT.UseVisualStyleBackColor = true;
            this.SQRT.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numsAfterDot
            // 
            resources.ApplyResources(this.numsAfterDot, "numsAfterDot");
            this.numsAfterDot.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numsAfterDot.Name = "numsAfterDot";
            this.numsAfterDot.ReadOnly = true;
            this.numsAfterDot.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numsAfterDot.ValueChanged += new System.EventHandler(this.numsAfterDot_ValueChanged);
            // 
            // ComplexSqrt
            // 
            resources.ApplyResources(this.ComplexSqrt, "ComplexSqrt");
            this.ComplexSqrt.Name = "ComplexSqrt";
            this.ComplexSqrt.UseVisualStyleBackColor = true;
            this.ComplexSqrt.Click += new System.EventHandler(this.ComplexSqrt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxRE
            // 
            resources.ApplyResources(this.textBoxRE, "textBoxRE");
            this.textBoxRE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRE.Name = "textBoxRE";
            this.textBoxRE.TextChanged += new System.EventHandler(this.TextBoxRE_TextChanged);
            // 
            // ClearButtonRE
            // 
            resources.ApplyResources(this.ClearButtonRE, "ClearButtonRE");
            this.ClearButtonRE.Name = "ClearButtonRE";
            this.ClearButtonRE.UseVisualStyleBackColor = true;
            this.ClearButtonRE.Click += new System.EventHandler(this.ClearButtonRE_Click);
            // 
            // textBoxIM
            // 
            resources.ApplyResources(this.textBoxIM, "textBoxIM");
            this.textBoxIM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIM.Name = "textBoxIM";
            this.textBoxIM.TextChanged += new System.EventHandler(this.textBoxIM_TextChanged);
            // 
            // ClearButtonIM
            // 
            resources.ApplyResources(this.ClearButtonIM, "ClearButtonIM");
            this.ClearButtonIM.Name = "ClearButtonIM";
            this.ClearButtonIM.UseVisualStyleBackColor = true;
            this.ClearButtonIM.Click += new System.EventHandler(this.ClearButtonIM_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearButtonIM);
            this.Controls.Add(this.textBoxIM);
            this.Controls.Add(this.ClearButtonRE);
            this.Controls.Add(this.textBoxRE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ComplexSqrt);
            this.Controls.Add(this.numsAfterDot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SQRT);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numsAfterDot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button SQRT;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numsAfterDot;
        private System.Windows.Forms.Button ComplexSqrt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRE;
        private System.Windows.Forms.Button ClearButtonRE;
        private System.Windows.Forms.TextBox textBoxIM;
        private System.Windows.Forms.Button ClearButtonIM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

