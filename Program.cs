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
            Console.WriteLine(result.Substring(2,2));
        }

        private static void lastIndexOfYap()
        {
            var result = cümleGir();
            Console.WriteLine(result.LastIndexOf("serdar"));
        }

        private static void ındexOfYap()
        {
            throw new NotImplementedException();
        }

        private static void startsWithYap()
        {
            throw new NotImplementedException();
        }

        private static void containsYap()
        {
            throw new NotImplementedException();
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
