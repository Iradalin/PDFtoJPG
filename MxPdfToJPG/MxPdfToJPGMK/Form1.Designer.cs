namespace MxPdfToJPGMK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUpuscPDF = new System.Windows.Forms.Panel();
            this.textBoxAdresPliku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonJpg = new System.Windows.Forms.RadioButton();
            this.radioButtonPNG = new System.Windows.Forms.RadioButton();
            this.radioButtonGIF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFolderOut = new System.Windows.Forms.TextBox();
            this.buttonAdresPlikuWyjsciowego = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownOsX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOsY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOsX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOsY)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpuscPDF
            // 
            this.panelUpuscPDF.AllowDrop = true;
            this.panelUpuscPDF.BackgroundImage = global::MxPdfToJPGMK.Properties.Resources.Tu_upuść_pdf;
            this.panelUpuscPDF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUpuscPDF.Location = new System.Drawing.Point(12, 175);
            this.panelUpuscPDF.Name = "panelUpuscPDF";
            this.panelUpuscPDF.Size = new System.Drawing.Size(357, 246);
            this.panelUpuscPDF.TabIndex = 0;
            this.panelUpuscPDF.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panelUpuscPDF.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panelUpuscPDF.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxAdresPliku
            // 
            this.textBoxAdresPliku.Location = new System.Drawing.Point(22, 29);
            this.textBoxAdresPliku.Name = "textBoxAdresPliku";
            this.textBoxAdresPliku.Size = new System.Drawing.Size(347, 20);
            this.textBoxAdresPliku.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres pliku";
            // 
            // radioButtonJpg
            // 
            this.radioButtonJpg.AutoSize = true;
            this.radioButtonJpg.Checked = true;
            this.radioButtonJpg.Location = new System.Drawing.Point(22, 69);
            this.radioButtonJpg.Name = "radioButtonJpg";
            this.radioButtonJpg.Size = new System.Drawing.Size(45, 17);
            this.radioButtonJpg.TabIndex = 2;
            this.radioButtonJpg.TabStop = true;
            this.radioButtonJpg.Text = "JPG";
            this.radioButtonJpg.UseVisualStyleBackColor = true;
            this.radioButtonJpg.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPNG
            // 
            this.radioButtonPNG.AutoSize = true;
            this.radioButtonPNG.Location = new System.Drawing.Point(113, 69);
            this.radioButtonPNG.Name = "radioButtonPNG";
            this.radioButtonPNG.Size = new System.Drawing.Size(48, 17);
            this.radioButtonPNG.TabIndex = 3;
            this.radioButtonPNG.Text = "PNG";
            this.radioButtonPNG.UseVisualStyleBackColor = true;
            this.radioButtonPNG.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonGIF
            // 
            this.radioButtonGIF.AutoSize = true;
            this.radioButtonGIF.Location = new System.Drawing.Point(204, 69);
            this.radioButtonGIF.Name = "radioButtonGIF";
            this.radioButtonGIF.Size = new System.Drawing.Size(42, 17);
            this.radioButtonGIF.TabIndex = 4;
            this.radioButtonGIF.Text = "GIF";
            this.radioButtonGIF.UseVisualStyleBackColor = true;
            this.radioButtonGIF.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres foldera pliku wyjściowego";
            // 
            // textBoxFolderOut
            // 
            this.textBoxFolderOut.Location = new System.Drawing.Point(22, 105);
            this.textBoxFolderOut.Name = "textBoxFolderOut";
            this.textBoxFolderOut.Size = new System.Drawing.Size(317, 20);
            this.textBoxFolderOut.TabIndex = 7;
            // 
            // buttonAdresPlikuWyjsciowego
            // 
            this.buttonAdresPlikuWyjsciowego.Location = new System.Drawing.Point(338, 105);
            this.buttonAdresPlikuWyjsciowego.Name = "buttonAdresPlikuWyjsciowego";
            this.buttonAdresPlikuWyjsciowego.Size = new System.Drawing.Size(31, 23);
            this.buttonAdresPlikuWyjsciowego.TabIndex = 8;
            this.buttonAdresPlikuWyjsciowego.Text = "....";
            this.buttonAdresPlikuWyjsciowego.UseVisualStyleBackColor = true;
            this.buttonAdresPlikuWyjsciowego.Click += new System.EventHandler(this.buttonAdresPlikuWyjsciowego_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rozdzielczość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            // 
            // numericUpDownOsX
            // 
            this.numericUpDownOsX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOsX.Location = new System.Drawing.Point(39, 139);
            this.numericUpDownOsX.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownOsX.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownOsX.Name = "numericUpDownOsX";
            this.numericUpDownOsX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownOsX.TabIndex = 14;
            this.numericUpDownOsX.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // numericUpDownOsY
            // 
            this.numericUpDownOsY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOsY.Location = new System.Drawing.Point(187, 139);
            this.numericUpDownOsY.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownOsY.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownOsY.Name = "numericUpDownOsY";
            this.numericUpDownOsY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownOsY.TabIndex = 15;
            this.numericUpDownOsY.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 433);
            this.Controls.Add(this.numericUpDownOsY);
            this.Controls.Add(this.numericUpDownOsX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdresPlikuWyjsciowego);
            this.Controls.Add(this.textBoxFolderOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonGIF);
            this.Controls.Add(this.radioButtonPNG);
            this.Controls.Add(this.radioButtonJpg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdresPliku);
            this.Controls.Add(this.panelUpuscPDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosed);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOsX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOsY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUpuscPDF;
        private System.Windows.Forms.TextBox textBoxAdresPliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonJpg;
        private System.Windows.Forms.RadioButton radioButtonPNG;
        private System.Windows.Forms.RadioButton radioButtonGIF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFolderOut;
        private System.Windows.Forms.Button buttonAdresPlikuWyjsciowego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownOsX;
        private System.Windows.Forms.NumericUpDown numericUpDownOsY;
    }
}

