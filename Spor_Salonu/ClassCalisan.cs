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
using System.Text;
using System.Threading.Tasks;

namespace Spor_Salonu
{
    partial class Calisan
    {
        //Alanlar
       private string _calisamAd;
       private string _calisanSoyad;
       private string _calisanMevki;
       private string _calisanTelefon;
       //Özellikler
        public string CalisanAd
        {
            get { return _calisamAd; }
            set { _calisamAd = value; }
        }
        public string CalisanSoyad
        {
            get { return _calisanSoyad; }
            set { _calisanSoyad = value; }
        }
        public string CalisanMevki
        {
            get { return _calisanMevki; }
            set { _calisanMevki = value; }

        }
        public string CalisanTelefon
        {
            get { return _calisanTelefon; }
            set { _calisanTelefon = value; }
        }
    }
}
