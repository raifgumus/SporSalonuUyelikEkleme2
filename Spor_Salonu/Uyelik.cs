/**************************************************************************** **     
 * **    SAKARYA ÜNİVERSİTESİ      
 * **    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
 * **    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ **      
 * **    NESNEYE DAYALI PROGRAMLAMA DERSİ **     
 * **    2019-2020 YAZ DÖNEMİ ** 
 * **    PROJE NUMARASI.........: 01
 * **    ÖĞRENCİ ADI............: Raif Gümüş
 * **    ÖĞRENCİ NUMARASI.......: s191200061
 * **    DERSİN ALINDIĞI GRUP...: A 
 * ****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spor_Salonu
{
    public partial class frmUyeEkle : Form
    {
        UyelerProvider uprovider = new UyelerProvider();
       // readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public frmUyeEkle()
        {
            InitializeComponent();
        }
        //Datagrid listeleme işlemi için metot. 
        void Listele() 
        {
            dtwUyelikTablo.DataSource = uprovider.Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Listele();

        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            Uyelik uye = new Uyelik();
            uye.tcNo = Convert.ToChar(txtTC.Text);
            uye.Ad = txtAd.Text;
            uye.Soyad = txtSoyad.Text;
            uye.Telefon = Convert.ToString(txtTelefon.Text);
            uye.Mail = txtMail.Text;
            uprovider.Ekle(uye);
            Listele();}

        private void btnSil_Click(object sender, EventArgs e)
        {
           Uyelik silinecekUye = new Uyelik();
            silinecekUye = (Uyelik)dtwUyelikTablo.CurrentRow.DataBoundItem;
            uprovider.Sil(silinecekUye);
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Uyelik eskiUyeler = new Uyelik();
            eskiUyeler = (Uyelik)dtwUyelikTablo.CurrentRow.DataBoundItem;
            Uyelik yeniUyeler = new Uyelik();
            yeniUyeler.tcNo =Convert.ToInt64 (txtTC.Text);
            yeniUyeler.Ad = txtAd.Text;
            yeniUyeler.Soyad = txtSoyad.Text;
            yeniUyeler.Telefon = txtTelefon.Text;
            yeniUyeler.Mail = txtMail.Text;
            uprovider.Guncelle(eskiUyeler, yeniUyeler);
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTC.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
        }

        private void uyelikBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

       

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
           Calisan form2sec = new Calisan();
            form2sec.Show();
            this.Hide();
        }
    }
}
