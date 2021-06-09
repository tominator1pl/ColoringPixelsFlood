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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxGridX = new System.Windows.Forms.TextBox();
            this.textBoxGridY = new System.Windows.Forms.TextBox();
            this.textBoxColors = new System.Windows.Forms.TextBox();
            this.textBoxMinColor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 595);
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
            // textBoxGridX
            // 
            this.textBoxGridX.Location = new System.Drawing.Point(16, 71);
            this.textBoxGridX.Name = "textBoxGridX";
            this.textBoxGridX.Size = new System.Drawing.Size(100, 20);
            this.textBoxGridX.TabIndex = 4;
            this.textBoxGridX.TextChanged += new System.EventHandler(this.textBoxGridX_TextChanged);
            // 
            // textBoxGridY
            // 
            this.textBoxGridY.Location = new System.Drawing.Point(16, 98);
            this.textBoxGridY.Name = "textBoxGridY";
            this.textBoxGridY.Size = new System.Drawing.Size(100, 20);
            this.textBoxGridY.TabIndex = 5;
            this.textBoxGridY.TextChanged += new System.EventHandler(this.textBoxGridY_TextChanged);
            // 
            // textBoxColors
            // 
            this.textBoxColors.Location = new System.Drawing.Point(16, 143);
            this.textBoxColors.Name = "textBoxColors";
            this.textBoxColors.Size = new System.Drawing.Size(100, 20);
            this.textBoxColors.TabIndex = 6;
            this.textBoxColors.TextChanged += new System.EventHandler(this.textBoxColors_TextChanged);
            // 
            // textBoxMinColor
            // 
            this.textBoxMinColor.Location = new System.Drawing.Point(16, 170);
            this.textBoxMinColor.Name = "textBoxMinColor";
            this.textBoxMinColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinColor.TabIndex = 7;
            this.textBoxMinColor.TextChanged += new System.EventHandler(this.textBoxMinColor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 619);
            this.Controls.Add(this.textBoxMinColor);
            this.Controls.Add(this.textBoxColors);
            this.Controls.Add(this.textBoxGridY);
            this.Controls.Add(this.textBoxGridX);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxGridX;
        private System.Windows.Forms.TextBox textBoxGridY;
        private System.Windows.Forms.TextBox textBoxColors;
        private System.Windows.Forms.TextBox textBoxMinColor;
    }
}

