using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Basılan_Tusu_Yakalama
{
    class Program
    {
        static void Main(string[] args)
        {

            string ad, soyad;

            Console.Write("Adınızı Giriniz:");

            ad = Console.ReadLine();

            Console.Write("Soyadınızı Giriniz:");

            soyad = Console.ReadLine();


            Console.WriteLine("BİLGİLERİNİZİ DOĞRULUYORUM...");

            Console.ReadLine();


            Console.Clear();

            Console.WriteLine("Eğer Ekranda Çıkan... " + "\n \nAdınız:" + ad + "\nSoyadınız:" + soyad);

            Console.WriteLine("Bilgileriniz Doğruysa Onaylamak İçin F2 Tuşuna \nEğer Bir Yanlışlık Varsa ESCAPE Tuşuna Basınız");

            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            if (KeyInfo.Key == ConsoleKey.F2)

                Console.WriteLine("\n \n \a GİRİŞ İŞLEMİNİZ BAŞARIYLA YAPILMIŞTIR");

            else if (KeyInfo.Key == ConsoleKey.Escape)

                Console.WriteLine("\n \n  \a GİRİŞ İŞLEMİ İÇİN BİLGİLERİNİZİ LÜTFEN DOĞRU GİRİNİZ");

            Console.ReadKey(); 

        }
    }
}
