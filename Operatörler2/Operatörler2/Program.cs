using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x++;  // önce y'ye 5 atanır, sonra x 6 olur
            int z = ++x;  // önce x 7 olur, sonra z'ye 7 atanır

            Console.WriteLine("x: " + x); // 7
            Console.WriteLine("y: " + y); // 5
            Console.WriteLine("z: " + z); // 7

            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            // Aritmetik işlemler
            Console.WriteLine("\nAritmetik İşlemler:");
            Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
            Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
            Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
            Console.WriteLine($"{sayi1} / {sayi2} = {(sayi2 != 0 ? (sayi1 / sayi2).ToString() : "Tanımsız")}");
            Console.WriteLine($"{sayi1} % {sayi2} = {(sayi2 != 0 ? (sayi1 % sayi2).ToString() : "Tanımsız")}");

            // Karşılaştırma ve mantıksal operatörler
            bool esitMi = (sayi1 == sayi2);
            bool buyukMu = (sayi1 > sayi2);
            bool mantik = (esitMi || buyukMu); // true dönerse sayi1 ya eşit ya da büyük

            Console.WriteLine("\nKarşılaştırma & Mantıksal:");
            Console.WriteLine("Eşit mi? " + esitMi);
            Console.WriteLine("Birinci sayı ikinci sayıdan büyük mü? " + buyukMu);
            Console.WriteLine("Eşit veya büyük mü? " + mantik);

            // Ternary örneği
            string mesaj = (sayi1 % 2 == 0) ? "Çift sayı" : "Tek sayı";
            Console.WriteLine($"\nBirinci sayı: {mesaj}");

        }
    }
}
