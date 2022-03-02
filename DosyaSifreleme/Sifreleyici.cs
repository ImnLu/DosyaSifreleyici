using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DosyaSifreleme
{
    public partial class Sifreleyici : Form
    {
        public Sifreleyici()
        {
            InitializeComponent();
        }

        private void buttonSifre_Click(object sender, EventArgs e)
        {
            // Dosyanın seçilip seçilmediğini kontrol ediyor.
            if (!string.IsNullOrEmpty(textDosya.Text))
            {
                // Dosyanın olup olmadığını kontrol ediyor.
                if (File.Exists(textDosya.Text))
                {
                    string kontrol = textDosya.Text.Substring(textDosya.Text.Length - 8, 8);

                    // Dosyanın şifrelenip şifrelenmediğini kontrol ediyor.
                    if (kontrol == "mencrypt")
                        MessageBox.Show("Bu dosya zaten şifrelenmiş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        // Dosyayı okuyup her karakteri bir sonraki karaktere dönüştürüyor.
                        Byte[] dosya = File.ReadAllBytes(textDosya.Text);
                        for (int i = 0; i < dosya.Length; i++)
                        {
                            dosya[i] = (Byte)((int)dosya[i] + 1);
                            if (dosya[i] > 255)
                            {
                                dosya[i] = 0;
                            }
                        }
                        File.WriteAllBytes(textDosya.Text + "mencrypt", dosya);
                        textDosya.Text = "";
                        MessageBox.Show("Dosya başarıyla şifrelendi!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Dosya bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen bir dosya seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSifreCoz_Click(object sender, EventArgs e)
        {
            // Dosyanın seçilip seçilmediğini kontrol ediyor.
            if (!string.IsNullOrEmpty(textDosya.Text))
            {
                // Dosyanın olup olmadığını kontrol ediyor.
                if (File.Exists(textDosya.Text))
                {
                    string kontrol = textDosya.Text.Substring(textDosya.Text.Length - 8, 8);
                    // Dosyanın şifrelenip şifrelenmediğini kontrol ediyor.
                    if (kontrol == "mencrypt")
                    {
                        // Dosyayı okuyup her karakteri bir önceki karaktere dönüştürüyor.
                        Byte[] dosya = File.ReadAllBytes(textDosya.Text);
                        for (int i = 0; i < dosya.Length; i++)
                        {
                            if (dosya[i] < 0)
                            {
                                dosya[i] = 255;
                            }
                            dosya[i] = (Byte)((int)dosya[i] - 1);
                        }
                        File.WriteAllBytes(textDosya.Text.Substring(0, textDosya.Text.Length - 8), dosya);
                        textDosya.Text = "";
                        MessageBox.Show("Dosyanın şifresi başarıyla çözüldü!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Bu dosya şifrelenmiş bir dosya değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Dosya bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Lütfen bir dosya seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonDosyaSec_Click(object sender, EventArgs e)
        {
            //Dosyyıa seçince dosyanın konumunu textbox'a yazdırıyor.
            if (DosyaSec.ShowDialog() == DialogResult.OK)
            {
                textDosya.Text = DosyaSec.FileName;
            }
        }

        private void Sifreleyici_Load(object sender, EventArgs e)
        {
            textDosya.TabStop = false;
            buttonDosyaSec.TabStop = false;
            buttonSifreCoz.TabStop = false;
            buttonSifrele.TabStop = false;
        }
    }
}
