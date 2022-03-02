namespace DosyaSifreleme
{
    partial class Sifreleyici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifreleyici));
            this.textDosya = new System.Windows.Forms.TextBox();
            this.buttonSifrele = new System.Windows.Forms.Button();
            this.buttonSifreCoz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDosyaSec = new System.Windows.Forms.Button();
            this.DosyaSec = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textDosya
            // 
            this.textDosya.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDosya.Location = new System.Drawing.Point(60, 6);
            this.textDosya.Name = "textDosya";
            this.textDosya.ReadOnly = true;
            this.textDosya.Size = new System.Drawing.Size(216, 23);
            this.textDosya.TabIndex = 0;
            // 
            // buttonSifrele
            // 
            this.buttonSifrele.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSifrele.Location = new System.Drawing.Point(102, 33);
            this.buttonSifrele.Name = "buttonSifrele";
            this.buttonSifrele.Size = new System.Drawing.Size(84, 37);
            this.buttonSifrele.TabIndex = 1;
            this.buttonSifrele.Text = "Şifrele";
            this.buttonSifrele.UseVisualStyleBackColor = true;
            this.buttonSifrele.Click += new System.EventHandler(this.buttonSifre_Click);
            // 
            // buttonSifreCoz
            // 
            this.buttonSifreCoz.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSifreCoz.Location = new System.Drawing.Point(192, 33);
            this.buttonSifreCoz.Name = "buttonSifreCoz";
            this.buttonSifreCoz.Size = new System.Drawing.Size(84, 37);
            this.buttonSifreCoz.TabIndex = 2;
            this.buttonSifreCoz.Text = "Şifreyi Çöz";
            this.buttonSifreCoz.UseVisualStyleBackColor = true;
            this.buttonSifreCoz.Click += new System.EventHandler(this.buttonSifreCoz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya:";
            // 
            // buttonDosyaSec
            // 
            this.buttonDosyaSec.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDosyaSec.Location = new System.Drawing.Point(12, 33);
            this.buttonDosyaSec.Name = "buttonDosyaSec";
            this.buttonDosyaSec.Size = new System.Drawing.Size(84, 37);
            this.buttonDosyaSec.TabIndex = 4;
            this.buttonDosyaSec.Text = "Dosyayı Seç";
            this.buttonDosyaSec.UseVisualStyleBackColor = true;
            this.buttonDosyaSec.Click += new System.EventHandler(this.buttonDosyaSec_Click);
            // 
            // DosyaSec
            // 
            this.DosyaSec.FileName = "DosyaSec";
            this.DosyaSec.Title = "Dosyayı Seçin";
            // 
            // Sifreleyici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 79);
            this.Controls.Add(this.buttonDosyaSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSifreCoz);
            this.Controls.Add(this.buttonSifrele);
            this.Controls.Add(this.textDosya);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sifreleyici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Şifreleyici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDosya;
        private System.Windows.Forms.Button buttonSifrele;
        private System.Windows.Forms.Button buttonSifreCoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDosyaSec;
        private System.Windows.Forms.OpenFileDialog DosyaSec;
    }
}

