
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
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox.Location = new System.Drawing.Point(0, 260);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(523, 41);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SQRT
            // 
            this.SQRT.Font = new System.Drawing.Font("Segoe UI", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SQRT.Location = new System.Drawing.Point(13, 13);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(559, 166);
            this.SQRT.TabIndex = 1;
            this.SQRT.Text = "Вывести корень из числа";
            this.SQRT.UseVisualStyleBackColor = true;
            this.SQRT.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.Location = new System.Drawing.Point(529, 260);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(41, 41);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 301);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SQRT);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button SQRT;
        private System.Windows.Forms.Button ClearButton;
    }
}

