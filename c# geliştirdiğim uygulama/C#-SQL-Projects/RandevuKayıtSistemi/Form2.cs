using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulamam1
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection(
        "Server=localhost;Database=randevu;Uid=root;Pwd=malatya44;Charset=utf8;");

        public Form2()
        {
            InitializeComponent();
        }

        

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Lütfen ad, soyad ve TC giriniz");
                return;
            }

            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT Id, Ad, Soyad, TelNo, TCKimlik, DogumTarihi, RandevuTarihi " +
                "FROM randevular WHERE Ad=@ad AND Soyad=@soyad AND TCKimlik=@tc", con);

            da.SelectCommand.Parameters.AddWithValue("@ad", txtAd.Text);
            da.SelectCommand.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            da.SelectCommand.Parameters.AddWithValue("@tc", txtTC.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Bu bilgilere ait randevu bulunamadı");
            }

            dataGridView1.DataSource = dt;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir randevu seçiniz");
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                "Seçilen randevuyu silmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo);

            if (sonuc != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["Id"].Value);

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM randevular WHERE Id=@id", con);

            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Randevu silindi");

            // Grid'i yenile
            btnAra_Click(null, null);
        }
        private void Form2_Load(object sender, EventArgs e)
        {    
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {      
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek randevuyu seçiniz");
                return;
            }

            Form3 frm = new Form3();

            frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            frm.Ad = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            frm.Soyad = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            frm.TelNo = dataGridView1.CurrentRow.Cells["TelNo"].Value.ToString();
            frm.TCKimlik = dataGridView1.CurrentRow.Cells["TCKimlik"].Value.ToString();
            frm.DogumTarihi = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DogumTarihi"].Value);
            frm.RandevuTarihi = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["RandevuTarihi"].Value);

            frm.Show();
            this.Hide();
        }

    }
}
