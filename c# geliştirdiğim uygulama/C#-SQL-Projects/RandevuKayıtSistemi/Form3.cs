using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulamam1
{
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection(
       "Server=localhost;Database=randevu;Uid=root;Pwd=malatya44;Charset=utf8;");

        public int id;
        public string Ad, Soyad, TelNo, TCKimlik;
        public DateTime DogumTarihi, RandevuTarihi;
        // Eski değerleri saklayacağız
        DateTime eskiRandevu;

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
                DateTime yeniRandevu =
                dtRandevuTarihi.Value.Date +
                dtRandevuSaati.Value.TimeOfDay;

            // Hiç değişiklik yapılmadıysa
            if (
                txtAd.Text == Ad &&
                txtSoyad.Text == Soyad &&
                txtTel.Text == TelNo &&
                txtTC.Text == TCKimlik &&
                dtDogumTarihi.Value.Date == DogumTarihi.Date &&
                yeniRandevu == eskiRandevu
               )
            {
                MessageBox.Show("Bir düzeltme yapmadınız");
                return;
            }

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE randevular SET " +
                "Ad=@ad, Soyad=@soyad, TelNo=@tel, TCKimlik=@tc, " +
                "DogumTarihi=@dogum, RandevuTarihi=@randevu " +
                "WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd.Parameters.AddWithValue("@tc", txtTC.Text);
            cmd.Parameters.AddWithValue("@dogum", dtDogumTarihi.Value.Date);
            cmd.Parameters.AddWithValue("@randevu", yeniRandevu);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Randevunuz başarıyla güncellendi");

            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
            txtAd.Text = Ad;
            txtSoyad.Text = Soyad;
            txtTel.Text = TelNo;
            txtTC.Text = TCKimlik;

            dtDogumTarihi.Value = DogumTarihi;
            dtRandevuTarihi.Value = RandevuTarihi.Date;
            dtRandevuSaati.Value = DateTime.Today + RandevuTarihi.TimeOfDay;

            eskiRandevu = RandevuTarihi;
        }
        
        

        public Form3()
        {
            InitializeComponent();
        }

        
    }
}
