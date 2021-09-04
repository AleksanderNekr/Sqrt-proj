
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
            ((System.ComponentModel.ISupportInitialize)(this.numsAfterDot)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox.Location = new System.Drawing.Point(13, 254);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(512, 41);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SQRT
            // 
            this.SQRT.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SQRT.Location = new System.Drawing.Point(12, 61);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(201, 119);
            this.SQRT.TabIndex = 1;
            this.SQRT.Text = "Арифметический корень из числа";
            this.SQRT.UseVisualStyleBackColor = true;
            this.SQRT.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.Location = new System.Drawing.Point(531, 254);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(41, 41);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество знаков после запятой";
            // 
            // numsAfterDot
            // 
            this.numsAfterDot.Location = new System.Drawing.Point(13, 187);
            this.numsAfterDot.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numsAfterDot.Name = "numsAfterDot";
            this.numsAfterDot.ReadOnly = true;
            this.numsAfterDot.Size = new System.Drawing.Size(43, 23);
            this.numsAfterDot.TabIndex = 5;
            this.numsAfterDot.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numsAfterDot.ValueChanged += new System.EventHandler(this.numsAfterDot_ValueChanged);
            // 
            // ComplexSqrt
            // 
            this.ComplexSqrt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComplexSqrt.Location = new System.Drawing.Point(240, 61);
            this.ComplexSqrt.Name = "ComplexSqrt";
            this.ComplexSqrt.Size = new System.Drawing.Size(201, 119);
            this.ComplexSqrt.TabIndex = 6;
            this.ComplexSqrt.Text = "Комплексный корень из числа";
            this.ComplexSqrt.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Русский",
            "English",
            "Español",
            "中国人"});
            this.comboBox1.Location = new System.Drawing.Point(13, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Язык";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 301);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}

