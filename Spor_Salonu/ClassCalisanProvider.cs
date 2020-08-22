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
using System.Linq;
using System.Data; //Ekle
using System.Data.SqlClient; //Ekle
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu
{
    class CalisanProvider
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public CalisanProvider() //Kurucu metot
        {
            Baglan();
        }
        public void Baglan()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=UyelikBilgi;Integrated Security=SSPI");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
        public List<Calisan> Listele()
        {
                 try
            {
                List<Calisan> calisanListesi = new List<Calisan>();
                komut.CommandText = "Select *From calisan";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Calisan yeniCalisan = new Calisan();
                    yeniCalisan.CalisanAd = reader[1].ToString();
                    yeniCalisan.CalisanSoyad = reader[2].ToString();
                    yeniCalisan.CalisanMevki = reader[3].ToString();
                    yeniCalisan.CalisanTelefon = reader[4].ToString();



                    calisanListesi.Add(yeniCalisan);
                }

                return calisanListesi;
            }
            catch
            { throw;
            } finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
        public void Ekle(Calisan yeniCalisan)
        {
            try
            {
                komut.CommandText = "Insert Into calisan (Ad,Soyad,Mevki,Telefon) Values (" + yeniCalisan.CalisanAd
                    + ",'" + yeniCalisan.CalisanSoyad + "','" + yeniCalisan.CalisanMevki + "','" + yeniCalisan.CalisanTelefon + "')";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }
        public void Guncelle(Calisan eskiCalisan, Calisan yeniCalisan)
        {
            try
            {
                komut.CommandText = "Update calisan SET Ad='" + yeniCalisan.CalisanAd +
                    "',Soyad='" + yeniCalisan.CalisanSoyad + "',Mevki='" + yeniCalisan.CalisanMevki + "',Telefon='" 
                    + yeniCalisan.CalisanTelefon + "' Where ad=" + eskiCalisan.CalisanAd + "";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }
        public void Sil(Calisan yeniCalisan)
        {
            try
            {
                komut.CommandText = "Delete From calisan Where Ad=" + yeniCalisan.CalisanAd + "";
                komut.CommandType = CommandType.Text;
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }

    }
}
