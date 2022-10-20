namespace ColoringPixelsFlood
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericColors = new System.Windows.Forms.NumericUpDown();
            this.numericMinColors = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guideLabel = new System.Windows.Forms.Label();
            this.turboCheckBox = new System.Windows.Forms.CheckBox();
            this.ignoreCheckBox = new System.Windows.Forms.CheckBox();
            this.skipSquareCheckLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinColors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(414, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of colors:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color to start with:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(371, 169);
            this.label7.TabIndex = 12;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 104);
            this.label8.TabIndex = 14;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // numericX
            // 
            this.numericX.AllowDrop = true;
            this.numericX.Location = new System.Drawing.Point(16, 87);
            this.numericX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(120, 20);
            this.numericX.TabIndex = 15;
            this.numericX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericX.ValueChanged += new System.EventHandler(this.numericX_ValueChanged);
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(16, 126);
            this.numericY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(120, 20);
            this.numericY.TabIndex = 16;
            this.numericY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericY.ValueChanged += new System.EventHandler(this.numericY_ValueChanged);
            // 
            // numericColors
            // 
            this.numericColors.Location = new System.Drawing.Point(16, 175);
            this.numericColors.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericColors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericColors.Name = "numericColors";
            this.numericColors.Size = new System.Drawing.Size(120, 20);
            this.numericColors.TabIndex = 17;
            this.numericColors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericColors.ValueChanged += new System.EventHandler(this.numericColors_ValueChanged);
            // 
            // numericMinColors
            // 
            this.numericMinColors.Location = new System.Drawing.Point(16, 223);
            this.numericMinColors.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericMinColors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMinColors.Name = "numericMinColors";
            this.numericMinColors.Size = new System.Drawing.Size(120, 20);
            this.numericMinColors.TabIndex = 18;
            this.numericMinColors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMinColors.ValueChanged += new System.EventHandler(this.numericMinColors_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guideLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 55);
            this.panel1.TabIndex = 19;
            // 
            // guideLabel
            // 
            this.guideLabel.AutoSize = true;
            this.guideLabel.Location = new System.Drawing.Point(0, 0);
            this.guideLabel.Margin = new System.Windows.Forms.Padding(0);
            this.guideLabel.MaximumSize = new System.Drawing.Size(395, 0);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(157, 13);
            this.guideLabel.TabIndex = 0;
            this.guideLabel.Text = "Press Alt + Numpad5 for Wizard";
            // 
            // turboCheckBox
            // 
            this.turboCheckBox.AutoSize = true;
            this.turboCheckBox.Location = new System.Drawing.Point(143, 75);
            this.turboCheckBox.Name = "turboCheckBox";
            this.turboCheckBox.Size = new System.Drawing.Size(111, 17);
            this.turboCheckBox.TabIndex = 20;
            this.turboCheckBox.Text = "Turbo (VSync Off)";
            this.turboCheckBox.UseVisualStyleBackColor = true;
            this.turboCheckBox.CheckedChanged += new System.EventHandler(this.turboCheckBox_CheckedChanged);
            // 
            // ignoreCheckBox
            // 
            this.ignoreCheckBox.AutoSize = true;
            this.ignoreCheckBox.Location = new System.Drawing.Point(143, 98);
            this.ignoreCheckBox.Name = "ignoreCheckBox";
            this.ignoreCheckBox.Size = new System.Drawing.Size(115, 17);
            this.ignoreCheckBox.TabIndex = 21;
            this.ignoreCheckBox.Text = "Skip square check";
            this.ignoreCheckBox.UseVisualStyleBackColor = true;
            this.ignoreCheckBox.CheckedChanged += new System.EventHandler(this.ignoreCheckBox_CheckedChanged);
            // 
            // skipSquareCheckLabel
            // 
            this.skipSquareCheckLabel.AutoSize = true;
            this.skipSquareCheckLabel.Location = new System.Drawing.Point(142, 118);
            this.skipSquareCheckLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.skipSquareCheckLabel.Name = "skipSquareCheckLabel";
            this.skipSquareCheckLabel.Size = new System.Drawing.Size(244, 91);
            this.skipSquareCheckLabel.TabIndex = 22;
            this.skipSquareCheckLabel.Text = resources.GetString("skipSquareCheckLabel.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 619);
            this.Controls.Add(this.skipSquareCheckLabel);
            this.Controls.Add(this.ignoreCheckBox);
            this.Controls.Add(this.turboCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericMinColors);
            this.Controls.Add(this.numericColors);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Coloring Pixels Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinColors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericColors;
        private System.Windows.Forms.NumericUpDown numericMinColors;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.CheckBox turboCheckBox;
        private System.Windows.Forms.CheckBox ignoreCheckBox;
        private System.Windows.Forms.Label skipSquareCheckLabel;
    }
}

