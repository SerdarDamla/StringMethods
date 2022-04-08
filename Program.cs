using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string secilenMetot = string.Empty;
            do
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: : (Çıkış için 0'a basınız.)");
                menüyüGöster();
                secilenMetot = Console.ReadLine();
                secilenİslemiYap(secilenMetot);

            } while (secilenMetot != "0");

        }

        private static string cümleGir()
        {
            Console.WriteLine("Bir cümle giriniz:");
            var result = Console.ReadLine();
            return result.ToUpper();
        }
        private static string aranıcakHarf()
        {
            Console.WriteLine("Aramak istediğiniz harfi giriniz:");
            var harf = Console.ReadLine().ToUpper();
            return harf;
        }
        private static void secilenİslemiYap(string secilenMetot)
        {
            switch (secilenMetot)
            {
                case "1":
                    containsYap();
                    break;
                case "2":
                    startsWithYap();
                    break;
                case "3":
                    ındexOfYap();
                    break;
                case "4":
                    lastIndexOfYap();
                    break;
                case "5":
                    substringYap();
                    break;
                default:
                    break;
            }
        }
        //Substring: Başlangıç indeximizi ve bu indexten sonra kaç karakter alıcağımızı seçip bunu bize veren metottur.
        private static void substringYap()
        {
            var result = cümleGir();
            Console.WriteLine(result.Substring(2, 2));
        }

        //Aramak istediğimiz harfi girip istersek başlamak istediğimiz indexi de girip o indexten başlayıp yazılan kelimenin içinde o harfi aramaya başlar. Aramaya sondan başlar ve aradığımız harfi ilk bulduğunda durur.
        private static void lastIndexOfYap()
        {
            var result = cümleGir();
            aranıcakHarf();
            Console.WriteLine(result.LastIndexOf(aranıcakHarf()));
        }
        //Aramak istediğimiz harfi girip istersek başlamak istediğimiz indexi de girip o indexten başlayıp yazılan kelimenin içinde o harfi aramaya başlar. Aramaya baştan başlar ve aradığımız harfi ilk bulduğunda durur.
        private static void ındexOfYap()
        {
            var result = cümleGir();
            aranıcakHarf();
            Console.WriteLine("Başlamak istdiğiniz indexi giriniz:");
            int index = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine(result.IndexOf(aranıcakHarf(), index));
        }
        //Yazdığımız kelime gireceğimiz harf ile başlıyor mu diye bool döndürmeye yarayan bir metot.
        private static void startsWithYap()
        {
            var result = cümleGir();
            var gelenHarf = aranıcakHarf();
            bool sonuc = result.StartsWith(gelenHarf);
            if (sonuc == true)
            {
                Console.WriteLine($"Kelimeniz {gelenHarf} harfi ile başlıyor!!");
            }
            else
            {
                Console.WriteLine($"Kelimeniz {gelenHarf} harfi ile başlamıyor!!");
            }
        }
        //Yazdığımız kelimenin içerisinde gireceğimiz harf geçiyor mu diye aramaya yarayan metot.
        private static void containsYap()
        {
            var result = cümleGir();
            var gelenHarf = aranıcakHarf();
            bool sonuc = result.Contains(gelenHarf);
            if (sonuc == true)
            {
                Console.WriteLine($"Kelimenizin içinde {gelenHarf} harfi bulunmaktadır!!");
            }
            else
            {
                Console.WriteLine($"Kelimeniz {gelenHarf} harfi bulunmamaktadır!!");
            }
        }

        private static void menüyüGöster()
        {
            Console.WriteLine("1. Contains");
            Console.WriteLine("2. StartsWith");
            Console.WriteLine("3. IndexOf");
            Console.WriteLine("4. LastIndexOf");
            Console.WriteLine("5. Substring");
        }
    }
}
