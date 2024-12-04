namespace toDecimalApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            mainLabel = new Label();
            nLabel = new Label();
            n = new NumericUpDown();
            nBaseIn = new TextBox();
            DecimalOut = new TextBox();
            nInLabel = new Label();
            decimalOutLabel = new Label();
            convBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)n).BeginInit();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.ImageAlign = ContentAlignment.TopCenter;
            mainLabel.Location = new Point(315, 16);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(160, 15);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "'n' base to decimal convertor";
            // 
            // nLabel
            // 
            nLabel.AutoSize = true;
            nLabel.Location = new Point(33, 79);
            nLabel.Name = "nLabel";
            nLabel.Size = new Size(178, 15);
            nLabel.TabIndex = 1;
            nLabel.Text = "What system is the number in ? :";
            // 
            // n
            // 
            n.Location = new Point(217, 77);
            n.Maximum = new decimal(new int[] { 36, 0, 0, 0 });
            n.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            n.Name = "n";
            n.Size = new Size(94, 23);
            n.TabIndex = 2;
            n.TextAlign = HorizontalAlignment.Center;
            n.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // nBaseIn
            // 
            nBaseIn.Location = new Point(54, 224);
            nBaseIn.Name = "nBaseIn";
            nBaseIn.Size = new Size(202, 23);
            nBaseIn.TabIndex = 3;
            // 
            // DecimalOut
            // 
            DecimalOut.Location = new Point(492, 224);
            DecimalOut.Name = "DecimalOut";
            DecimalOut.ReadOnly = true;
            DecimalOut.Size = new Size(212, 23);
            DecimalOut.TabIndex = 4;
            // 
            // nInLabel
            // 
            nInLabel.AutoSize = true;
            nInLabel.Location = new Point(54, 206);
            nInLabel.Name = "nInLabel";
            nInLabel.Size = new Size(44, 15);
            nInLabel.TabIndex = 5;
            nInLabel.Text = "n base:";
            // 
            // decimalOutLabel
            // 
            decimalOutLabel.AutoSize = true;
            decimalOutLabel.Location = new Point(492, 206);
            decimalOutLabel.Name = "decimalOutLabel";
            decimalOutLabel.Size = new Size(53, 15);
            decimalOutLabel.TabIndex = 6;
            decimalOutLabel.Text = "Decimal:";
            // 
            // convBtn
            // 
            convBtn.Location = new Point(217, 325);
            convBtn.Name = "convBtn";
            convBtn.Size = new Size(370, 31);
            convBtn.TabIndex = 7;
            convBtn.Text = "Convert";
            convBtn.UseVisualStyleBackColor = true;
            convBtn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(convBtn);
            Controls.Add(decimalOutLabel);
            Controls.Add(nInLabel);
            Controls.Add(DecimalOut);
            Controls.Add(nBaseIn);
            Controls.Add(n);
            Controls.Add(nLabel);
            Controls.Add(mainLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)n).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private Label nLabel;
        private NumericUpDown n;
        private TextBox nBaseIn;
        private TextBox DecimalOut;
        private Label nInLabel;
        private Label decimalOutLabel;
        private Button convBtn;
        public Label ErrorBox;
    }
}
