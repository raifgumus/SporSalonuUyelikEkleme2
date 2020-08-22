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
    p class Uyelik
    {  // Üyelik adlı sınıfın oluşturuluması


        //Alanlar
            
            long _tcNo;
            string _ad;
            string _soyad;
            string _telefon;
            string _mail;
        //Özellikler
          public long tcNo
            {
                get { return _tcNo; }
                set { _tcNo = value; }
            }
            public string Ad
            {
                get { return _ad; }
                set { _ad = value; }
            }
            public string Soyad
            {
                get { return _soyad; }
                set { _soyad = value; }
            }
            
            public string Telefon
            {
                get { return _telefon; }
                set { _telefon = value; }
            }
            public string Mail
            {
                get { return _mail; }
                set { _mail = value; }
            }

       

        }
    }
}
