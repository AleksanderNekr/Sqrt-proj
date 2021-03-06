
namespace Sqrt
{
    partial class SquareRootProgram
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SquareRootProgram));
            this.label1 = new System.Windows.Forms.Label();
            this.DecPointDigitsCount = new System.Windows.Forms.NumericUpDown();
            this.ComplexSqrt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRE = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearButtonRE = new System.Windows.Forms.Button();
            this.ClearButtonIM = new System.Windows.Forms.Button();
            this.textBoxIM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plMinBtnRE = new System.Windows.Forms.Button();
            this.plMinBtnIM = new System.Windows.Forms.Button();
            this.CopyBtnRE = new System.Windows.Forms.Button();
            this.CopyBtnIM = new System.Windows.Forms.Button();
            this.TextBoxAnalityc = new System.Windows.Forms.TextBox();
            this.ClearBtnAnalityc = new System.Windows.Forms.Button();
            this.AnalyticSqrt = new System.Windows.Forms.Button();
            this.SinBtn = new System.Windows.Forms.Button();
            this.CosBtn = new System.Windows.Forms.Button();
            this.TanBtn = new System.Windows.Forms.Button();
            this.CotBtn = new System.Windows.Forms.Button();
            this.XBtn = new System.Windows.Forms.Button();
            this.Pow2Btn = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnLeftBr = new System.Windows.Forms.Button();
            this.BtnRightBr = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DecPointDigitsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DecPointDigitsCount
            // 
            resources.ApplyResources(this.DecPointDigitsCount, "DecPointDigitsCount");
            this.DecPointDigitsCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.DecPointDigitsCount.Name = "DecPointDigitsCount";
            this.DecPointDigitsCount.ReadOnly = true;
            this.DecPointDigitsCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
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
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBoxRE
            // 
            this.textBoxRE.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.textBoxRE, "textBoxRE");
            this.textBoxRE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRE.Name = "textBoxRE";
            this.textBoxRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRE_KeyPress_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // ClearButtonRE
            // 
            resources.ApplyResources(this.ClearButtonRE, "ClearButtonRE");
            this.ClearButtonRE.Name = "ClearButtonRE";
            this.ClearButtonRE.UseVisualStyleBackColor = true;
            this.ClearButtonRE.Click += new System.EventHandler(this.ClearButtonRE_Click);
            // 
            // ClearButtonIM
            // 
            resources.ApplyResources(this.ClearButtonIM, "ClearButtonIM");
            this.ClearButtonIM.Name = "ClearButtonIM";
            this.ClearButtonIM.UseVisualStyleBackColor = true;
            this.ClearButtonIM.Click += new System.EventHandler(this.ClearButtonIM_Click);
            // 
            // textBoxIM
            // 
            this.textBoxIM.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.textBoxIM, "textBoxIM");
            this.textBoxIM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIM.Name = "textBoxIM";
            this.textBoxIM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxIM_KeyPress_1);
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
            // 
            // plMinBtnRE
            // 
            resources.ApplyResources(this.plMinBtnRE, "plMinBtnRE");
            this.plMinBtnRE.Name = "plMinBtnRE";
            this.plMinBtnRE.UseVisualStyleBackColor = true;
            this.plMinBtnRE.Click += new System.EventHandler(this.PlusMinusBtnRE_Click);
            // 
            // plMinBtnIM
            // 
            resources.ApplyResources(this.plMinBtnIM, "plMinBtnIM");
            this.plMinBtnIM.Name = "plMinBtnIM";
            this.plMinBtnIM.UseVisualStyleBackColor = true;
            this.plMinBtnIM.Click += new System.EventHandler(this.PlusMinusBtnIM_Click);
            // 
            // CopyBtnRE
            // 
            resources.ApplyResources(this.CopyBtnRE, "CopyBtnRE");
            this.CopyBtnRE.Name = "CopyBtnRE";
            this.CopyBtnRE.UseVisualStyleBackColor = true;
            this.CopyBtnRE.Click += new System.EventHandler(this.CopyBtnRE_Click);
            // 
            // CopyBtnIM
            // 
            resources.ApplyResources(this.CopyBtnIM, "CopyBtnIM");
            this.CopyBtnIM.Name = "CopyBtnIM";
            this.CopyBtnIM.UseVisualStyleBackColor = true;
            this.CopyBtnIM.Click += new System.EventHandler(this.CopyBtnIM_Click);
            // 
            // TextBoxAnalityc
            // 
            resources.ApplyResources(this.TextBoxAnalityc, "TextBoxAnalityc");
            this.TextBoxAnalityc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxAnalityc.Name = "TextBoxAnalityc";
            this.TextBoxAnalityc.ReadOnly = true;
            // 
            // ClearBtnAnalityc
            // 
            resources.ApplyResources(this.ClearBtnAnalityc, "ClearBtnAnalityc");
            this.ClearBtnAnalityc.Name = "ClearBtnAnalityc";
            this.ClearBtnAnalityc.UseVisualStyleBackColor = true;
            this.ClearBtnAnalityc.Click += new System.EventHandler(this.ClearBtnAnalytic_Click);
            // 
            // AnalyticSqrt
            // 
            resources.ApplyResources(this.AnalyticSqrt, "AnalyticSqrt");
            this.AnalyticSqrt.Name = "AnalyticSqrt";
            this.AnalyticSqrt.UseVisualStyleBackColor = true;
            this.AnalyticSqrt.Click += new System.EventHandler(this.AnalyticSqrt_Click);
            // 
            // SinBtn
            // 
            resources.ApplyResources(this.SinBtn, "SinBtn");
            this.SinBtn.Name = "SinBtn";
            this.SinBtn.UseVisualStyleBackColor = true;
            this.SinBtn.Click += new System.EventHandler(this.SinBtn_Click);
            // 
            // CosBtn
            // 
            resources.ApplyResources(this.CosBtn, "CosBtn");
            this.CosBtn.Name = "CosBtn";
            this.CosBtn.UseVisualStyleBackColor = true;
            this.CosBtn.Click += new System.EventHandler(this.CosBtn_Click);
            // 
            // TanBtn
            // 
            resources.ApplyResources(this.TanBtn, "TanBtn");
            this.TanBtn.Name = "TanBtn";
            this.TanBtn.UseVisualStyleBackColor = true;
            this.TanBtn.Click += new System.EventHandler(this.TanBtn_Click);
            // 
            // CotBtn
            // 
            resources.ApplyResources(this.CotBtn, "CotBtn");
            this.CotBtn.Name = "CotBtn";
            this.CotBtn.UseVisualStyleBackColor = true;
            this.CotBtn.Click += new System.EventHandler(this.CotBtn_Click);
            // 
            // XBtn
            // 
            resources.ApplyResources(this.XBtn, "XBtn");
            this.XBtn.Name = "XBtn";
            this.XBtn.UseVisualStyleBackColor = true;
            this.XBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Pow2Btn
            // 
            resources.ApplyResources(this.Pow2Btn, "Pow2Btn");
            this.Pow2Btn.Name = "Pow2Btn";
            this.Pow2Btn.UseVisualStyleBackColor = true;
            this.Pow2Btn.Click += new System.EventHandler(this.Pow2Btn_Click);
            // 
            // BtnMinus
            // 
            resources.ApplyResources(this.BtnMinus, "BtnMinus");
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnPlus
            // 
            resources.ApplyResources(this.BtnPlus, "BtnPlus");
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnLeftBr
            // 
            resources.ApplyResources(this.BtnLeftBr, "BtnLeftBr");
            this.BtnLeftBr.Name = "BtnLeftBr";
            this.BtnLeftBr.UseVisualStyleBackColor = true;
            this.BtnLeftBr.Click += new System.EventHandler(this.BtnLeftBr_Click);
            // 
            // BtnRightBr
            // 
            resources.ApplyResources(this.BtnRightBr, "BtnRightBr");
            this.BtnRightBr.Name = "BtnRightBr";
            this.BtnRightBr.UseVisualStyleBackColor = true;
            this.BtnRightBr.Click += new System.EventHandler(this.BtnRightBr_Click);
            // 
            // BtnMult
            // 
            resources.ApplyResources(this.BtnMult, "BtnMult");
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnDiv
            // 
            resources.ApplyResources(this.BtnDiv, "BtnDiv");
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // SquareRootProgram
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnRightBr);
            this.Controls.Add(this.BtnLeftBr);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Pow2Btn);
            this.Controls.Add(this.XBtn);
            this.Controls.Add(this.CotBtn);
            this.Controls.Add(this.TanBtn);
            this.Controls.Add(this.CosBtn);
            this.Controls.Add(this.SinBtn);
            this.Controls.Add(this.AnalyticSqrt);
            this.Controls.Add(this.ClearBtnAnalityc);
            this.Controls.Add(this.TextBoxAnalityc);
            this.Controls.Add(this.CopyBtnIM);
            this.Controls.Add(this.CopyBtnRE);
            this.Controls.Add(this.plMinBtnIM);
            this.Controls.Add(this.plMinBtnRE);
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
            this.Controls.Add(this.DecPointDigitsCount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SquareRootProgram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DecPointDigitsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DecPointDigitsCount;
        private System.Windows.Forms.Button ComplexSqrt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRE;
        private System.Windows.Forms.Button ClearButtonRE;
        private System.Windows.Forms.Button ClearButtonIM;
        private System.Windows.Forms.TextBox textBoxIM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button plMinBtnRE;
        private System.Windows.Forms.Button plMinBtnIM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button CopyBtnRE;
        private System.Windows.Forms.Button CopyBtnIM;
        private System.Windows.Forms.TextBox TextBoxAnalityc;
        private System.Windows.Forms.Button ClearBtnAnalityc;
        private System.Windows.Forms.Button AnalyticSqrt;
        private System.Windows.Forms.Button SinBtn;
        private System.Windows.Forms.Button CosBtn;
        private System.Windows.Forms.Button TanBtn;
        private System.Windows.Forms.Button CotBtn;
        private System.Windows.Forms.Button XBtn;
        private System.Windows.Forms.Button Pow2Btn;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnLeftBr;
        private System.Windows.Forms.Button BtnRightBr;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnDiv;
    }
}

