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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericColors = new System.Windows.Forms.NumericUpDown();
            this.numericMinColors = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinColors)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(414, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(371, 143);
            this.label7.TabIndex = 12;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ColoringPixelsFlood.Properties.Resources.Capture;
            this.pictureBox3.Location = new System.Drawing.Point(329, 378);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 78);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alt + Numpad 1 - Start\r\nAlt + Numpad 2 - Pause\r\nAlt + Numpad 3 - Resume\r\nAlt + Nu" +
    "mpad 4 - Skip a color\r\n\r\nMake sure that Coloring pixels are in focus";
            // 
            // numericX
            // 
            this.numericX.AllowDrop = true;
            this.numericX.Location = new System.Drawing.Point(16, 87);
            this.numericX.Minimum = new decimal(new int[] {
            1,
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
            50,
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 619);
            this.Controls.Add(this.numericMinColors);
            this.Controls.Add(this.numericColors);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericColors;
        private System.Windows.Forms.NumericUpDown numericMinColors;
        private System.Windows.Forms.NumericUpDown numericX;
    }
}

