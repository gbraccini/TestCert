namespace TestCert
{
    partial class splash
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
            this.pBarCert = new System.Windows.Forms.ProgressBar();
            this.pictureBoxSheet = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // pBarCert
            // 
            this.pBarCert.Location = new System.Drawing.Point(12, 178);
            this.pBarCert.Name = "pBarCert";
            this.pBarCert.Size = new System.Drawing.Size(597, 51);
            this.pBarCert.TabIndex = 0;
            // 
            // pictureBoxSheet
            // 
            this.pictureBoxSheet.Image = global::TestCert.Resource1.sheep_preview;
            this.pictureBoxSheet.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSheet.Name = "pictureBoxSheet";
            this.pictureBoxSheet.Size = new System.Drawing.Size(196, 148);
            this.pictureBoxSheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSheet.TabIndex = 1;
            this.pictureBoxSheet.TabStop = false;
            this.pictureBoxSheet.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Waiting please, loading certificates....";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(621, 262);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSheet);
            this.Controls.Add(this.pBarCert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Activated += new System.EventHandler(this.splash_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.splash_FormClosed);
            this.Load += new System.EventHandler(this.splash_Load);
            this.Shown += new System.EventHandler(this.splash_Shown);
            this.BackColorChanged += new System.EventHandler(this.splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBarCert;
        private System.Windows.Forms.PictureBox pictureBoxSheet;
        private System.Windows.Forms.Label label1;
    }
}