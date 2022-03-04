using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace DosyaSifreleme
{
    public partial class Sifreleyici : Form
    {
        public Sifreleyici()
        {
            InitializeComponent();
        }

        private void DecryptFile(string inputFile, string outputFile)
        {
            try
            {
                string password = @"MaliMali";

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("Şifre çözme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        // Şifreleme işlemini başlatıyor.
                        try
                        {
                            string password = @"MaliMali"; // Şifrelidiği parola.
                            UnicodeEncoding UE = new UnicodeEncoding();
                            byte[] key = UE.GetBytes(password);

                            string cryptFile = textDosya.Text + "mencrypt";
                            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                            RijndaelManaged RMCrypto = new RijndaelManaged();

                            CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);

                            FileStream fsIn = new FileStream(textDosya.Text, FileMode.Open);

                            int data;
                            while ((data = fsIn.ReadByte()) != -1)
                                cs.WriteByte((byte)data);

                            fsIn.Close();
                            cs.Close();
                            fsCrypt.Close();

                            textDosya.Text = "";
                            MessageBox.Show("Dosya başarıyla şifrelendi!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Şifreleme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                        // Şifre çözme işlemini başlatıyor.
                        try
                        {
                            string password = @"MaliMali"; // Şifreyi çözerken deneyeceği parola.

                            UnicodeEncoding UE = new UnicodeEncoding();
                            byte[] key = UE.GetBytes(password);

                            FileStream fsCrypt = new FileStream(textDosya.Text, FileMode.Open);

                            RijndaelManaged RMCrypto = new RijndaelManaged();

                            CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read);

                            FileStream fsOut = new FileStream(textDosya.Text.Substring(0, textDosya.Text.Length - 8), FileMode.Create);

                            int data;
                            while ((data = cs.ReadByte()) != -1)
                                fsOut.WriteByte((byte)data);

                            fsOut.Close();
                            cs.Close();
                            fsCrypt.Close();

                            textDosya.Text = "";
                            MessageBox.Show("Dosyanın şifresi başarıyla çözüldü!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Şifre çözme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
