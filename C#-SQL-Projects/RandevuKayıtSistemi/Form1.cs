using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulamam1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(
       "Server=localhost;Database=randevu;Uid=root;Pwd=malatya44;Charset=utf8;");

        public Form1()
        {
            InitializeComponent();
        }
            private void btnRandevuAl_Click(object sender, EventArgs e)
            {
                // BOŞ KONTROL
                if (string.IsNullOrWhiteSpace(txtad.Text) ||
                    string.IsNullOrWhiteSpace(txtsoyad.Text) ||
                    string.IsNullOrWhiteSpace(txttelNo.Text) ||
                    string.IsNullOrWhiteSpace(txttckimlik.Text))
                {
                    MessageBox.Show("Eksik bir bilgi bıraktınız");
                    return;
                }

                string Ad = txtad.Text;
                string Soyad = txtsoyad.Text;
                long TelNo = Convert.ToInt64(txttelNo.Text);
                long Tckimlik = Convert.ToInt64(txttckimlik.Text);

                DateTime DogumTarihi = dtpDogumtarihi.Value.Date;

                DateTime RandevuTarihi =
                    dtpRandevuGunu.Value.Date + dtpRandevuSaat.Value.TimeOfDay;

                // ⛔ AYNI TARİH & SAAT KONTROLÜ
                MySqlCommand kontrol = new MySqlCommand(
                    "SELECT COUNT(*) FROM randevular WHERE RandevuTarihi=@date", con);

                kontrol.Parameters.AddWithValue("@date", RandevuTarihi);

                con.Open();
                int varMi = Convert.ToInt32(kontrol.ExecuteScalar());
                con.Close();

                if (varMi > 0)
                {
                    MessageBox.Show("Bu tarih ve saatte başka bir randevu var");
                    return;
                }

                // 💾 KAYIT
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO randevular " +
                    "(Ad, Soyad, TelNo, TCKimlik, DogumTarihi, RandevuTarihi) " +
                    "VALUES (@ad, @soyad, @tel, @tc, @dogum, @randevu)", con);

                cmd.Parameters.AddWithValue("@ad", Ad);
                cmd.Parameters.AddWithValue("@soyad", Soyad);
                cmd.Parameters.AddWithValue("@tel", TelNo);
                cmd.Parameters.AddWithValue("@tc", Tckimlik);
                cmd.Parameters.AddWithValue("@dogum", DogumTarihi);
                cmd.Parameters.AddWithValue("@randevu", RandevuTarihi);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Randevunuz başarıyla kaydedildi");
            }

            private void btnKayıtlıRandevularım_Click(object sender, EventArgs e)
            {
                Form2 frm = new Form2();
                frm.Show();
            }
        }
    }
