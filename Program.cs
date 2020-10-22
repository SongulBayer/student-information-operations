/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI:1.ÖDEV
**				ÖĞRENCİ ADI SOYADI: SONGÜL BAYER
**				ÖĞRENCİ NUMARASI:B191210065
**              DERSİN ALINDIĞI GRUP:1-C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            //BU ÖDEV 20 ÖĞRENCİ VARSAYILARAK HAZIRLANMIŞTIR
            int harf_notu1 = 0, harf_notu2 = 0, harf_notu3 = 0, harf_notu4 = 0, harf_notu5 = 0, harf_notu6 = 0, harf_notu7 = 0, harf_notu8 = 0, harf_notu9 = 0;

            string dosyaKONUMU = @"C:\Users\songül bayer\source\repos\ödev\ödev\sonuclar.txt";//TEXT DOSYANIN KONUMUNU BELİRTTİM
            string[] satirlar = System.IO.File.ReadAllLines(dosyaKONUMU); //TEXT DOSYASININ SATIRLARINI DİZİNİN ELEMANLARI OLARAK ATADIM
            string ogr1_adi_soyadi = satirlar[0];//TEXTİN 1. SATIRI YANİ DİZİNİN O. ELEMEANI ÖĞRENCİNİN ADI SOYADİ BİLGİLERİNİ TUTUYOR 
            string ogr1_numarasi = satirlar[1];//TEXTİN 2. SATIRI YANİ DİZİNİN 1. ELEMEANI ÖĞRENCİNİN ADI SOYADİ BİLGİLERİNİ TUTUYOR 
            string ogr1_vizenotu = satirlar[2];//TEXTİN 3. SATIRI YANİ DİZİNİN 2. ELEMEANI ÖĞRENCİNİN ADI SOYADİ BİLGİLERİNİ TUTUYOR 
            string ogr1_ödev1 = satirlar[3];//TEXTİN 4. SATIRI YANİ DİZİNİN 3. ELEMEANI ÖĞRENCİNİN ADI SOYADİ BİLGİLERİNİ TUTUYOR 
            string ogr1_ödev2 = satirlar[4];//TEXTİN 5. SATIRI YANİ DİZİNİN 4. ELEMEANI ÖĞRENCİNİN ADI SOYADİ BİLGİLERİNİ TUTUYOR 
            string ogr1_final = satirlar[5];//TEXTİN 6. SATIRI YANİ DİZİNİN 5. ELEMEANI ÖĞRENCİNİN ADI SOYADİ BİLGİLERİNİ TUTUYOR.
            //BU OLAY DİĞER TÜM ÖĞRENCİLER İÇİN DEVAM EDİYOR

            double ortalama = (Convert.ToInt32(ogr1_vizenotu) * 0.1) + (Convert.ToInt32(ogr1_ödev1) * 0.1)
            + (Convert.ToInt32(ogr1_ödev2) * 0.2) + (Convert.ToInt32(ogr1_final) * 0.6);//BURADA ORTALAMAYI HESAPLADIM VE DOUBLE OLAN DEĞİŞKENİ INT A DÖNÜŞTÜRDÜM 
            Console.WriteLine(ogr1_adi_soyadi);
            Console.WriteLine(ogr1_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr1_vizenotu + ' ' + ogr1_ödev1 + ' ' + ogr1_ödev2 + ' ' + ogr1_final);
            harf_notu();//VOİD TÜRÜNDE BİR harf_notu FONKSİYONU OLUŞTUDUM VE HER ÖĞRENCİNİN HARF NOTUNU EKRANA ÇIKARTTIM
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");//BUNU SİZİN GÖZ ZEVKİNİZ İÇİN YAPTIM :)


            string ogr2_adi_soyadi = satirlar[6];
            string ogr2_numarasi = satirlar[7];
            string ogr2_vizenotu = satirlar[8];
            string ogr2_odev1 = satirlar[9];
            string ogr2_odev2 = satirlar[10];
            string ogr2_final = satirlar[11];

            ortalama = (Convert.ToInt32(ogr2_vizenotu) * 0.1) + (Convert.ToInt32(ogr2_odev1) * 0.1) + (Convert.ToInt32(ogr2_odev2) * 0.2) + (Convert.ToInt32(ogr2_final) * 0.6);
            Console.WriteLine(ogr2_adi_soyadi);
            Console.WriteLine(ogr2_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr2_vizenotu + ' ' + ogr2_odev1 + ' ' + ogr2_odev2 + ' ' + ogr2_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr3_adi_soyadi = satirlar[12];
            string ogr3_numarasi = satirlar[13];
            string ogr3_vizenotu = satirlar[14];
            string ogr3_odev1 = satirlar[15];
            string ogr3_ödev2 = satirlar[16];
            string ogr3_final = satirlar[17];

            ortalama = (Convert.ToInt32(ogr3_vizenotu) * 0.1) + (Convert.ToInt32(ogr3_odev1) * 0.1) + (Convert.ToInt32(ogr3_ödev2) * 0.2) + (Convert.ToInt32(ogr3_final) * 0.6);
            Console.WriteLine(ogr3_adi_soyadi);
            Console.WriteLine(ogr3_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr3_vizenotu + ' ' + ogr3_odev1 + ' ' + ogr3_ödev2 + ' ' + ogr3_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr4_adi_soyadi = satirlar[18];
            string ogr4_numarasi = satirlar[19];
            string ogr4_vizenotu = satirlar[20];
            string ogr4_ödev1 = satirlar[21];
            string ogr4_ödev2 = satirlar[22];
            string ogr4_final = satirlar[23];

            ortalama = (Convert.ToInt32(ogr4_vizenotu) * 0.1) + (Convert.ToInt32(ogr4_ödev1) * 0.1) + (Convert.ToInt32(ogr4_ödev2) * 0.2) + (Convert.ToInt32(ogr4_final) * 0.6);
            Console.WriteLine(ogr4_adi_soyadi);
            Console.WriteLine(ogr4_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr4_vizenotu + ' ' + ogr4_ödev1 + ' ' + ogr4_ödev2 + ' ' + ogr4_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr5_adi_soyadi = satirlar[24];
            string ogr5_numarasi = satirlar[25];
            string ogr5_vizenotu = satirlar[26];
            string ogr5_ödev1 = satirlar[27];
            string ogr5_ödev2 = satirlar[28];
            string ogr5_final = satirlar[29];

            ortalama = (Convert.ToInt32(ogr5_vizenotu) * 0.1 + (Convert.ToInt32(ogr5_ödev1) * 0.1) + (Convert.ToInt32(ogr5_ödev2) * 0.2) + (Convert.ToInt32(ogr5_final) * 0.6));
            Console.WriteLine(ogr5_adi_soyadi);
            Console.WriteLine(ogr5_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr5_vizenotu + ' ' + ogr5_ödev1 + ' ' + ogr5_ödev2 + ' ' + ogr5_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr6_adi_soyadi = satirlar[30];
            string ogr6_numarasi = satirlar[31];
            string ogr6_vizenotu = satirlar[32];
            string ogr6_ödev1 = satirlar[33];
            string ogr6_ödev2 = satirlar[34];
            string ogr6_final = satirlar[35];

            ortalama = (Convert.ToInt32(ogr6_vizenotu) * 0.1) + (Convert.ToInt32(ogr6_ödev1) * 0.1) + (Convert.ToInt32(ogr6_ödev2) * 0.2) + (Convert.ToInt32(ogr6_final) * 0.6);
            Console.WriteLine(ogr6_adi_soyadi);
            Console.WriteLine(ogr6_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr6_vizenotu + ' ' + ogr6_ödev1 + ' ' + ogr6_ödev2 + ' ' + ogr6_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr7_adi_soyadi = satirlar[36];
            string ogr7_numarasi = satirlar[37];
            string ogr7_vizenotu = satirlar[38];
            string ogr7_ödev1 = satirlar[39];
            string ogr7_ödev2 = satirlar[40];
            string ogr7_final = satirlar[41];

            ortalama = (Convert.ToInt32(ogr7_vizenotu) * 0.1) + (Convert.ToInt32(ogr7_ödev1) * 0.1) + (Convert.ToInt32(ogr7_ödev2) * 0.2) + (Convert.ToInt32(ogr7_final) * 0.6);
            Console.WriteLine(ogr7_adi_soyadi);
            Console.WriteLine(ogr7_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr7_vizenotu + ' ' + ogr7_ödev1 + ' ' + ogr7_ödev2 + ' ' + ogr7_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr8_adi_soyadi = satirlar[42];
            string ogr8_numarasi = satirlar[43];
            string ogr8_vizenotu = satirlar[44];
            string ogr8_ödev1 = satirlar[45];
            string ogr8_ödev2 = satirlar[46];
            string ogr8_final = satirlar[47];

            ortalama = (Convert.ToInt32(ogr8_vizenotu) * 0.1) + (Convert.ToInt32(ogr8_ödev1) * 0.1) + (Convert.ToInt32(ogr8_ödev2) * 0.2) + (Convert.ToInt32(ogr8_final) * 0.6);
            Console.WriteLine(ogr8_adi_soyadi);
            Console.WriteLine(ogr8_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr8_vizenotu + ' ' + ogr8_ödev1 + ' ' + ogr8_ödev2 + ' ' + ogr8_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr9_adi_soyadi = satirlar[48];
            string ogr9_numarasi = satirlar[49];
            string ogr9_vizenotu = satirlar[50];
            string ogr9_ödev1 = satirlar[51];
            string ogr9_ödev2 = satirlar[52];
            string ogr9_final = satirlar[53];

            ortalama = (Convert.ToInt32(ogr9_vizenotu) * 0.1) + (Convert.ToInt32(ogr9_ödev1) * 0.1) + (Convert.ToInt32(ogr9_ödev2) * 0.2) + (Convert.ToInt32(ogr9_final) * 0.6);
            Console.WriteLine(ogr9_adi_soyadi);
            Console.WriteLine(ogr9_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr9_vizenotu + ' ' + ogr9_ödev1 + ' ' + ogr9_ödev2 + ' ' + ogr9_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr10_adi_soyadi = satirlar[54];
            string ogr10_numarasi = satirlar[55];
            string ogr10_vizenotu = satirlar[56];
            string ogr10_ödev1 = satirlar[57];
            string ogr10_ödev2 = satirlar[58];
            string ogr10_final = satirlar[59];

            ortalama = (Convert.ToInt32(ogr10_vizenotu) * 0.1) + (Convert.ToInt32(ogr10_ödev1) * 0.1) + (Convert.ToInt32(ogr10_ödev2) * 0.2) + (Convert.ToInt32(ogr10_final) * 0.6);
            Console.WriteLine(ogr10_adi_soyadi);
            Console.WriteLine(ogr10_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr10_vizenotu + ' ' + ogr10_ödev1 + ' ' + ogr10_ödev2 + ' ' + ogr10_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr11_adi_soyadi = satirlar[60];
            string ogr11_numarasi = satirlar[61];
            string ogr11_vizenotu = satirlar[62];
            string ogr11_ödev1 = satirlar[63];
            string ogr11_ödev2 = satirlar[64];
            string ogr11_final = satirlar[65];


            ortalama = (Convert.ToInt32(ogr11_vizenotu) * 0.1) + (Convert.ToInt32(ogr11_ödev1) * 0.1) + (Convert.ToInt32(ogr11_ödev2) * 0.2) + (Convert.ToInt32(ogr11_final) * 0.6);
            Console.WriteLine(ogr11_adi_soyadi);
            Console.WriteLine(ogr11_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr11_vizenotu + ' ' + ogr11_ödev1 + ' ' + ogr11_ödev2 + ' ' + ogr11_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr12_adi_soyadi = satirlar[66];
            string ogr12_numarasi = satirlar[67];
            string ogr12_vizenotu = satirlar[68];
            string ogr12_ödev1 = satirlar[69];
            string ogr12_ödev2 = satirlar[70];
            string ogr12_final = satirlar[71];


            ortalama = (Convert.ToInt32(ogr12_vizenotu) * 0.1) + (Convert.ToInt32(ogr12_ödev1) * 0.1) + (Convert.ToInt32(ogr12_ödev2) * 0.2) + (Convert.ToInt32(ogr12_final) * 0.6);
            Console.WriteLine(ogr12_adi_soyadi);
            Console.WriteLine(ogr12_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr12_vizenotu + ' ' + ogr12_ödev1 + ' ' + ogr12_ödev2 + ' ' + ogr12_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr13_adi_soyadi = satirlar[72];
            string ogr13_numarasi = satirlar[73];
            string ogr13_vizenotu = satirlar[77];
            string ogr13_ödev1 = satirlar[75];
            string ogr13_ödev2 = satirlar[76];
            string ogr13_final = satirlar[77];

            ortalama = (Convert.ToInt32(ogr13_vizenotu) * 0.1) + (Convert.ToInt32(ogr13_ödev1) * 0.1) + (Convert.ToInt32(ogr13_ödev2) * 0.2) + (Convert.ToInt32(ogr13_final) * 0.6);
            Console.WriteLine(ogr13_adi_soyadi);
            Console.WriteLine(ogr13_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr13_vizenotu + ' ' + ogr13_ödev1 + ' ' + ogr13_ödev2 + ' ' + ogr13_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr14_adi_soyadi = satirlar[78];
            string ogr14_numarasi = satirlar[79];
            string ogr14_vizenotu = satirlar[80];
            string ogr14_ödev1 = satirlar[81];
            string ogr14_ödev2 = satirlar[82];
            string ogr14_final = satirlar[83];

            ortalama = (Convert.ToInt32(ogr14_vizenotu) * 0.1) + (Convert.ToInt32(ogr14_ödev1) * 0.1) + (Convert.ToInt32(ogr14_ödev2) * 0.2) + (Convert.ToInt32(ogr14_final) * 0.6);
            Console.WriteLine(ogr14_adi_soyadi);
            Console.WriteLine(ogr14_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr14_vizenotu + ' ' + ogr14_ödev1 + ' ' + ogr14_ödev2 + ' ' + ogr14_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr15_adi_soyadi = satirlar[84];
            string ogr15_numarasi = satirlar[85];
            string ogr15_vizenotu = satirlar[86];
            string ogr15_ödev1 = satirlar[87];
            string ogr15_ödev2 = satirlar[88];
            string ogr15_final = satirlar[89];

            ortalama = (Convert.ToInt32(ogr15_vizenotu) * 0.1) + (Convert.ToInt32(ogr15_ödev1) * 0.1) + (Convert.ToInt32(ogr15_ödev2) * 0.2) + (Convert.ToInt32(ogr15_final) * 0.6);
            Console.WriteLine(ogr15_adi_soyadi);
            Console.WriteLine(ogr15_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr15_vizenotu + ' ' + ogr15_ödev1 + ' ' + ogr15_ödev2 + ' ' + ogr15_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr16_adi_soyadi = satirlar[90];
            string ogr16_numarasi = satirlar[91];
            string ogr16_vizenotu = satirlar[92];
            string ogr16_ödev1 = satirlar[93];
            string ogr16_ödev2 = satirlar[94];
            string ogr16_final = satirlar[95];

            ortalama = (Convert.ToInt32(ogr16_vizenotu) * 0.1) + (Convert.ToInt32(ogr16_ödev1) * 0.1) + (Convert.ToInt32(ogr16_ödev2) * 0.2) + (Convert.ToInt32(ogr16_final) * 0.6);
            Console.WriteLine(ogr16_adi_soyadi);
            Console.WriteLine(ogr16_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr16_vizenotu + ' ' + ogr16_ödev1 + ' ' + ogr16_ödev2 + ' ' + ogr16_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr17_adi_soyadi = satirlar[96];
            string ogr17_numarasi = satirlar[97];
            string ogr17_vizenotu = satirlar[98];
            string ogr17_ödev1 = satirlar[99];
            string ogr17_ödev2 = satirlar[100];
            string ogr17_final = satirlar[101];

            ortalama = (Convert.ToInt32(ogr17_vizenotu) * 0.1) + (Convert.ToInt32(ogr17_ödev1) * 0.1) + (Convert.ToInt32(ogr17_ödev2) * 0.2) + (Convert.ToInt32(ogr17_final) * 0.6);
            Console.WriteLine(ogr17_adi_soyadi);
            Console.WriteLine(ogr17_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr17_vizenotu + ' ' + ogr17_ödev1 + ' ' + ogr17_ödev2 + ' ' + ogr17_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr18_adi_soyadi = satirlar[102];
            string ogr18_numarasi = satirlar[103];
            string ogr18_vizenotu = satirlar[104];
            string ogr18_ödev1 = satirlar[105];
            string ogr18_ödev2 = satirlar[106];
            string ogr18_final = satirlar[107];

            ortalama = (Convert.ToInt32(ogr18_vizenotu) * 0.1) + (Convert.ToInt32(ogr18_ödev1) * 0.1) + (Convert.ToInt32(ogr18_ödev2) * 0.2) + (Convert.ToInt32(ogr18_final) * 0.6);
            Console.WriteLine(ogr18_adi_soyadi);
            Console.WriteLine(ogr18_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr18_vizenotu + ' ' + ogr18_ödev1 + ' ' + ogr18_ödev2 + ' ' + ogr18_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            string ogr19_adi_soyadi = satirlar[108];
            string ogr19_numarasi = satirlar[109];
            string ogr19_vizenotu = satirlar[110];
            string ogr19_ödev1 = satirlar[111];
            string ogr19_ödev2 = satirlar[112];
            string ogr19_final = satirlar[113];

            ortalama = (Convert.ToInt32(ogr19_vizenotu) * 0.1) + (Convert.ToInt32(ogr19_ödev1) * 0.1) + (Convert.ToInt32(ogr19_ödev2) * 0.2) + (Convert.ToInt32(ogr19_final) * 0.6);
            Console.WriteLine(ogr19_adi_soyadi);
            Console.WriteLine(ogr19_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr19_vizenotu + ' ' + ogr19_ödev1 + ' ' + ogr19_ödev2 + ' ' + ogr19_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string ogr20_adi_soyadi = satirlar[114];
            string ogr20_numarasi = satirlar[115];
            string ogr20_vizenotu = satirlar[116];
            string ogr20_ödev1 = satirlar[117];
            string ogr20_ödev2 = satirlar[118];
            string ogr20_final = satirlar[119];

            ortalama = (Convert.ToInt32(ogr20_vizenotu) * 0.1) + (Convert.ToInt32(ogr20_ödev1) * 0.1) + (Convert.ToInt32(ogr20_ödev2) * 0.2) + (Convert.ToInt32(ogr20_final) * 0.6);
            Console.WriteLine(ogr20_adi_soyadi);
            Console.WriteLine(ogr20_numarasi);
            Console.Write("OGRENCİNİN NOTLARI:");
            Console.WriteLine(ogr20_vizenotu + ' ' + ogr20_ödev1 + ' ' + ogr20_ödev2 + ' ' + ogr20_final);
            harf_notu();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");




            void harf_notu()
            {
                if (ortalama <= 39.99 && ortalama > 0)
                {
                    harf_notu9++;
                    Console.WriteLine("Ogrencinin Harf Notu:'FF'");

                }
                if (ortalama <= 49.99 && ortalama > 39.99)
                {
                    harf_notu8++;
                    Console.WriteLine("Ogrencinin Harf Notu:'FD'");

                }
                if (ortalama <= 57.99 && ortalama > 49.99)
                {
                    harf_notu7++;
                    Console.WriteLine("Ogrencinin Harf Notu:'DD'");

                }
                if (ortalama <= 64.99 && ortalama > 57.99)
                {
                    harf_notu6++;
                    Console.WriteLine("Ogrencinin Harf Notu:'DC'");

                }
                if (ortalama <= 74.99 && ortalama > 64.99)
                {
                    harf_notu5++;
                    Console.WriteLine("Ogrencinin Harf Notu:'CC'");

                }
                if (ortalama <= 79.99 && ortalama > 74.99)
                {
                    harf_notu4++;
                    Console.WriteLine("Ogrencinin Harf Notu:'CB'");

                }
                if (ortalama <= 84.99 && ortalama > 79.99)
                {
                    harf_notu3++;
                    Console.WriteLine("Ogrencinin Harf Notu:'BB'");

                }
                if (ortalama <= 89.99 && ortalama > 84.99)
                {
                    harf_notu2++;
                    Console.WriteLine("Ogrencinin Harf Notu:'BA'");

                }
                if (ortalama <= 100 && ortalama > 89.99)
                {
                    harf_notu1++;
                    Console.WriteLine("Ogrencinin Harf Notu:'AA'");

                }
            }
            //SINIF GENELİNDE HARF NOTLARININ SAYISINI YAZDIRDIM
            Console.Write("AA HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu1++);
            Console.Write("BA HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu2++);
            Console.Write("BB HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu3++);
            Console.Write("CB HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu4++);
            Console.Write("CC HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu5++);
            Console.Write("DC HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu6++);
            Console.Write("DD HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu7++);
            Console.Write("FD HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu8++);
            Console.Write("FF HARF NOTUNUN SAYISI:");
            Console.WriteLine(harf_notu9++);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //SINIF GENELİNDE HARF NOTLARININ YÜZDELİĞİNİ YAZDIRDIM
            Console.Write("AA Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu1 - 1) * 5);
            Console.Write("BA Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu2 - 1) * 5);
            Console.Write("BB Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu3 - 1) * 5);
            Console.Write("CB Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu4 - 1) * 5);
            Console.Write("CC Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu5 - 1) * 5);
            Console.Write("DC Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu6 - 1) * 5);
            Console.Write("DD Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu7 - 1) * 5);
            Console.Write("FD Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu8 - 1) * 5);
            Console.Write("FF Harf Notunun Yüzdeligi:%");
            Console.WriteLine((harf_notu9 - 1) * 5);


            //OGRENCİ BİLGİLERİNİ DAHA İYİ ANALİZ EDEBİLMEK İÇİN VERİLERİ BAŞKA BİR TEXT DOSYASINA AKTARDIM AŞŞAĞIDA DA HANGİ BİLGİLERİN AKTARILACAĞI BELİRTİLDİ
            string[] ogr_analız = {"AA HARF NOTU SAYISI:" +harf_notu1+"\nBA HARF NOTU SAYISI:"+harf_notu2+"\nBB HARF NOTU SAYISI:"+harf_notu3+
            "\nCB HARF NOTU SAYISI:"+harf_notu4+"\nCC HARF NOTU SAYISI:"+harf_notu5+"\nCC HARF NOTU SAYISI:"+harf_notu5+"\nDC HARF NOTU SAYISI:"+
            harf_notu6+"\nDD HARF NOTU SAYISI:"+harf_notu7+"\nFD HARF NOTU SAYISI:"+harf_notu8+"\nFF HARF NOTU SAYISI:"+harf_notu9+
            "\nAA HARF NOTUNUN YUZDELİGİ:%" + (harf_notu1 - 1) * 5 + "\nBA HARF NOTUNUN YUZDELİGİ:%" + (harf_notu2 - 1) * 5 +
            "\nBB HARF NOTUNUN YUZDELIGI:%" + (harf_notu3 - 1) * 5 + "\nCB HARF NOTUNUN YUZDEIGI:%" + (harf_notu4 - 1) * 5 + "\nCC HARF NOTUNUN YUZDEIGI:%"
            + (harf_notu5 + -1) * 5 + "\nDC HARF NOTUNUN YUZDELIGI:%" + (harf_notu6 - 1) * 5 + "\nDD HARF NOTUNUN YUZDELIGI:%" + (harf_notu7 - 1) * 5 + "\nFD HARF NOTUNUN YUZDELİGİ:%"
            + (harf_notu8 - 1) * 5 + "\nFF HARF NOTUNUN YUZDELIGI:%" + (harf_notu9 - 1) * 5 +
            "\nOGRENCİ BİLGİLERİ:" + ogr1_adi_soyadi + "" + ogr1_numarasi + "\nOGRENCI NOTLARI:" +
            ogr1_vizenotu + " " + ogr1_ödev1 + " " + ogr1_ödev2 + " " + ogr1_final + " " +
            "\nOGRENCİ BİLGİLERİ:" + ogr2_adi_soyadi + " " + ogr2_numarasi + "\nOGRENCI NOTLARI:" +
            ogr2_vizenotu + " " + ogr2_odev1 + " " + ogr2_odev2 + " " + ogr2_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr3_adi_soyadi + " " + ogr3_numarasi + "\nOGRENCI NOTLARI:" +
            ogr3_vizenotu + " " + ogr3_odev1 + " " + ogr3_ödev2 + " " + ogr3_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr4_adi_soyadi + " " + ogr4_numarasi + "\nOGRENCI NOTLARI:" +
            ogr4_vizenotu + " " + ogr4_ödev1 + " " + ogr4_ödev2 + " " + ogr4_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr5_adi_soyadi + " " + ogr1_numarasi + "\nOGRENCI NOTLARI:" +
            ogr5_vizenotu + " " + ogr5_ödev1 + " " + ogr5_ödev2 + " " + ogr5_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr6_adi_soyadi + " " + ogr6_numarasi + "\nOGRENCI NOTLARI:" +
            ogr6_vizenotu + " " + ogr6_ödev1 + " " + ogr6_ödev2 + " " + ogr6_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr7_adi_soyadi + " " + ogr7_numarasi + "\nOGRENCI NOTLARI:" +
            ogr7_vizenotu + " " + ogr7_ödev1 + " " + ogr7_ödev2 + " " + ogr7_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr8_adi_soyadi + " " + ogr8_numarasi + "\nOGRENCI NOTLARI:" +
            ogr8_vizenotu + " " + ogr8_ödev1 + " " + ogr8_ödev2 + " " + ogr8_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr9_adi_soyadi + " " + ogr9_numarasi + "\nOGRENCI NOTLARI:" +
            ogr9_vizenotu + " " + ogr9_ödev1 + " " + ogr9_ödev2 + " " + ogr9_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr10_adi_soyadi + " " + ogr10_numarasi + "\nOGRENCI NOTLARI:" +
            ogr10_vizenotu + " " + ogr10_ödev1 + " " + ogr10_ödev2 + " " + ogr10_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr11_adi_soyadi + " " + ogr11_numarasi + "\nOGRENCI NOTLARI:" +
            ogr11_vizenotu + " " + ogr11_ödev1 + " " + ogr11_ödev2 + " " + ogr11_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr12_adi_soyadi + " " + ogr12_numarasi + "\nOGRENCI NOTLARI:" +
            ogr12_vizenotu + " " + ogr12_ödev1 + " " + ogr12_ödev2 + " " + ogr12_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr13_adi_soyadi + " " + ogr13_numarasi + "\nOGRENCI NOTLARI:" +
            ogr13_vizenotu + " " + ogr13_ödev1 + " " + ogr13_ödev2 + " " + ogr13_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr14_adi_soyadi + " " + ogr14_numarasi + "\nOGRENCI NOTLARI:" +
            ogr14_vizenotu + " " + ogr14_ödev1 + " " + ogr14_ödev2 + " " + ogr14_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr15_adi_soyadi + " " + ogr15_numarasi + "\nOGRENCI NOTLARI:" +
            ogr15_vizenotu + " " + ogr15_ödev1 + " " + ogr15_ödev2 + " " + ogr15_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr16_adi_soyadi + " " + ogr16_numarasi + "\nOGRENCI NOTLARI:" +
            ogr16_vizenotu + " " + ogr16_ödev1 + " " + ogr16_ödev2 + " " + ogr16_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr17_adi_soyadi + " " + ogr17_numarasi + "\nOGRENCI NOTLARI:" +
            ogr17_vizenotu + " " + ogr17_ödev1 + " " + ogr17_ödev2 + " " + ogr17_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr18_adi_soyadi + " " + ogr18_numarasi + "\nOGRENCI NOTLARI:" +
            ogr18_vizenotu + " " + ogr18_ödev1 + " " + ogr18_ödev2 + " " + ogr18_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr19_adi_soyadi + " " + ogr19_numarasi + "\nOGRENCI NOTLARI:" +
            ogr19_vizenotu + " " + ogr19_ödev1 + " " + ogr19_ödev2 + " " + ogr19_final +
            "\nOGRENCİ BİLGİLERİ:" + ogr20_adi_soyadi + " " + ogr20_numarasi + "\nOGRENCI NOTLARI:" +
            ogr20_vizenotu + " " + ogr20_ödev1 + " " + ogr20_ödev2 + " " + ogr20_final };

            //AŞŞAGIDA YUKARIDAKİ BİLGİLERİN TXT DOSYASINA AKTARMAMIZA YARDIMCI FONKSİYON VAR
            System.IO.File.WriteAllLines(@"C:\Users\songül bayer\source\repos\ödev\ödev\analız.txt", ogr_analız);
            Console.ReadKey();
            

       }
        


           

        
    }

}
