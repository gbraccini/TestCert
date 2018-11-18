namespace TestCert
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_add_certificate = new System.Windows.Forms.Button();
            this.listBoxCert = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_add_certificate
            // 
            this.button_add_certificate.Location = new System.Drawing.Point(664, 435);
            this.button_add_certificate.Name = "button_add_certificate";
            this.button_add_certificate.Size = new System.Drawing.Size(142, 23);
            this.button_add_certificate.TabIndex = 0;
            this.button_add_certificate.Text = "Add Firebird certificate";
            this.button_add_certificate.UseVisualStyleBackColor = true;
            this.button_add_certificate.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxCert
            // 
            this.listBoxCert.FormattingEnabled = true;
            this.listBoxCert.Location = new System.Drawing.Point(12, 3);
            this.listBoxCert.Name = "listBoxCert";
            this.listBoxCert.Size = new System.Drawing.Size(794, 420);
            this.listBoxCert.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 470);
            this.Controls.Add(this.listBoxCert);
            this.Controls.Add(this.button_add_certificate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I.T.I.S.  Antonio Meucci   < engineered by Gianluca Braccini  november 2018>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_certificate;
        private System.Windows.Forms.ListBox listBoxCert;
    }
}

