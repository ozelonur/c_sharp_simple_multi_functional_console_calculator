using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuGoster();
        }

        private static void MenuGoster()
        {
            int secilenIslem;
            do
            {
                Console.WriteLine("1 - Topla\n" +
                              "2 - Çıkar\n" +
                              "3 - Çarp\n" +
                              "4 - Böl\n" +
                              "5 - Modunu Al\n" +
                              "6 - Mutlak Değerini Al\n" +
                              "7 - Karekökünü Al\n" +
                              "8 - En Büyüğünü Göster\n" +
                              "9 - En Küçüğünü Göster\n" +
                              "10 - Üs Alma\n" +
                              "11 - Logaritmasını Al\n" +
                              "12 - Açının Sinüsü\n" +
                              "13 - Açının Kosinüsü\n" +
                              "14 - Açının Tanjantı\n" +
                              "0 - Çıkış\n");
                secilenIslem = Convert.ToInt32(Console.ReadLine());

                switch (secilenIslem)
                {
                    case 1:
                        Topla();
                        break;
                    case 2:
                        Cikar();
                        break;
                    case 3:
                        Carp();
                        break;
                    case 4:
                        Bol();
                        break;
                    case 5:
                        ModunuAl();
                        break;
                    case 6:
                        MutlakDegeriniAl();
                        break;
                    case 7:
                        KareKokunuAl();
                        break;
                    case 8:
                        EnBuyuguGoster();
                        break;
                    case 9:
                        EnKucuguGoster();
                        break;
                    case 10:
                        UsAl();
                        break;
                    case 11:
                        LogaritmaAl();
                        break;
                    case 12:
                        SinusAl();
                        break;
                    case 13:
                        CosinusAl();
                        break;
                    case 14:
                        TanAl();
                        break;
                    case 0:                       
                        goto cikis;
                        break;
                    default:
                        Console.WriteLine("Yanlış Bir İşlem Seçtiniz Lütfen Tekrar Deneyiniz!");
                        break;

                }

            } while (secilenIslem != 0);
            
            
            
            Console.ReadKey();
            cikis:
            Console.WriteLine("Çıkış Yapılıyor...");

        }

        private static void TanAl()
        {
            Console.WriteLine("\n--- TANJANT ALMA İŞLEMİ ---\n");

            Console.WriteLine("Açı Gir :");
            int aci = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("tan" + aci + " = " + Math.Tan(aci));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void CosinusAl()
        {
            Console.WriteLine("\n--- COSİNUS ALMA İŞLEMİ ---\n");

            Console.WriteLine("Açı Gir :");
            int aci = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("cos" + aci + " = " + Math.Cos(aci));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void SinusAl()
        {
            Console.WriteLine("\n--- SİNÜS ALMA İŞLEMİ ---\n");

            Console.WriteLine("Açı Gir :");
            int aci = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("sin" + aci + " = "+Math.Sin(aci));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void LogaritmaAl()
        {
            Console.WriteLine("\n--- LOGARİTMA ALMA İŞLEMİ ---\n");

            Console.WriteLine("Logaritmasını Almak İstediğin Sayıyı Gir :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Logaritma Tabanını Gir :");
            int taban = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("log" + taban + "(" + sayi + ")" + " = " + Math.Log(sayi, taban));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void UsAl()
        {
            Console.WriteLine("\n--- ÜS ALMA İŞLEMİ ---\n");

            Console.WriteLine("Sayıyı Gir :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üssü Gir :");
            int us = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayi+" ^ "+us+" = "+Math.Pow(sayi,us));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void EnKucuguGoster()
        {
            Console.WriteLine("\n--- İKİ SAYIDAN KÜÇÜĞÜNÜ SEÇME İŞLEMİ ---\n");

            Console.WriteLine("Birinci Sayıyı Gir :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Gir :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayi1 + " ve " + sayi2 + " sayısından küçük olan :" + Math.Min(sayi1, sayi2));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void EnBuyuguGoster()
        {
            Console.WriteLine("\n--- İKİ SAYIDAN BÜYÜĞÜNÜ SEÇME İŞLEMİ ---\n");

            Console.WriteLine("Birinci Sayıyı Gir :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Gir :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayi1 + " ve " + sayi2 + " sayısından büyük olan :" + Math.Max(sayi1, sayi2));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void KareKokunuAl()
        {
            Console.WriteLine("\n--- KAREKÖK ALMA İŞLEMİ ---\n");

            Console.WriteLine("Karekökünü Almak İstediğin Sayıyı Gir :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(Math.Sqrt(sayi));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void MutlakDegeriniAl()
        {
            Console.WriteLine("\n--- MUTLAK DEĞER ALMA İŞLEMİ ---\n");

            Console.WriteLine("Mutlak Değerini Almak İstediğiniz Sayıyı Giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(Math.Abs(sayi));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void ModunuAl()
        {
            Console.WriteLine("\n--- MOD ALMA İŞLEMİ ---\n");

            Console.WriteLine("Birinci Sayıyı Gir :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Gir :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayi1 + " % " + sayi2 + " = " + (sayi1 % sayi2));
            Console.Write("-------------------------------------------------"+"\n\n");
        }

        private static void Bol()
        {
            Console.WriteLine("\n--- BÖLME İŞLEMİ ---\n");

            Console.WriteLine("Birinci Sayıyı Gir :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Gir :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if(sayi2 != 0)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine(sayi1 + " / " + sayi2 + " = " + (sayi1 / sayi2));
                Console.Write("-------------------------------------------------" + "\n\n");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Bölen 0 olduğu için bu işlem yapılamaz!!!");
                Console.Write("-------------------------------------------------" + "\n\n");
            }

        }

        private static void Carp()
        {
            Console.WriteLine("\n--- ÇARPMA İŞLEMİ ---\n");

            Console.WriteLine("Birinci Sayıyı Gir :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Gir :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));
            Console.Write("-------------------------------------------------" + "\n\n");
        }

        private static void Cikar()
        {
            Console.WriteLine("\n--- ÇIKARMA İŞLEMİ ---\n");

            Console.WriteLine("Birinci Sayıyı Gir :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Gir :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
            Console.Write("-------------------------------------------------" + "\n\n");
        }

        private static void Topla()
        {
            Console.WriteLine("\n--- TOPLAMA İŞLEMİ ---\n");

            Console.WriteLine("Birinci Sayıyı Gir :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Gir :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(sayi1 + " + " + sayi2 + " = " + (sayi1 + sayi2));
            Console.Write("-------------------------------------------------"+"\n\n");
        }
    }
}
