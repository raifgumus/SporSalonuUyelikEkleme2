using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spor_Salonu
{
    public partial class Calisan : Form
    {
        CalisanProvider cp = new CalisanProvider();
        public Calisan()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            dtwCalisan.DataSource = cp.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan yeniCalisan = new Calisan();

            yeniCalisan.CalisanAd = txtCalisanAdi.Text;
            yeniCalisan.CalisanSoyad = txtCalisanSoyadi.Text;
            yeniCalisan.CalisanMevki = txtCalisanMevki.Text;
            yeniCalisan.CalisanTelefon = txtCalisanTelefon.Text;
            cp.Ekle(yeniCalisan);
            Listele();
        }

        private void Calisan_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'uyelikBilgiDataSet.calisan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanTableAdapter.Fill(this.uyelikBilgiDataSet.calisan);
            Listele();
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            Calisan silinecekCalisan = new Calisan();
            silinecekCalisan = (Calisan)dtwCalisan.CurrentRow.DataBoundItem;
            cp.Sil(silinecekCalisan);
            Listele();
        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            Calisan eskicalisan = new Calisan();
            eskicalisan = (Calisan)dtwCalisan.CurrentRow.DataBoundItem;
            Calisan yenicalisan = new Calisan();
            yenicalisan.CalisanAd = txtCalisanAdi.Text;
            yenicalisan.CalisanSoyad = txtCalisanSoyadi.Text;
            yenicalisan.CalisanMevki = txtCalisanMevki.Text;
            yenicalisan.CalisanTelefon = txtCalisanTelefon.Text;
            cp.Guncelle(eskicalisan, yenicalisan);
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCalisanAdi.Clear();
            txtCalisanSoyadi.Clear();
            txtCalisanMevki.Clear();
            txtCalisanTelefon.Clear();
        }

        private void BtnFormDegistir_Click(object sender, EventArgs e)
        {
            frmUyeEkle form2sec = new frmUyeEkle();
            form2sec.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgiler kaydedildi. Çıkış Yapılıyor");
            this.Close();
            Application.Exit();
        }
    }
}
