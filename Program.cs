using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double minimumUcret = 2.0;
            double saatUcreti = 0.5;
            double musteri1Ucret = 0.0;
            double musteri2Ucret = 0.0;
            double musteri3Ucret = 0.0;


            Console.WriteLine("1. Müşterinin Park Süresi:");
            double musteri1Saat = Convert.ToDouble(Console.ReadLine());
            
            
            if (musteri1Saat <= 3)
            {
                musteri1Ucret = minimumUcret;
                Console.WriteLine(musteri1Ucret);
            }
            else if (musteri1Saat <= 24)
            {
                
                musteri1Ucret = minimumUcret + (musteri1Saat - 3) * saatUcreti;
                Console.WriteLine($"ücret 1 :{musteri1Ucret}$");
            }


            Console.WriteLine("2. Müşterinin Park Süresi :");
            double musteri2Saat = Convert.ToDouble(Console.ReadLine());
            

            if (musteri2Saat <= 3)
            {
                musteri2Ucret = minimumUcret;
                Console.WriteLine(musteri2Ucret);
            }
            else if (musteri2Saat <= 24)
            {
                musteri2Ucret = minimumUcret + (musteri2Saat - 3) * saatUcreti;
                Console.WriteLine($"ücret 2 :{musteri2Ucret}$");
            }




            Console.WriteLine("3. Müşterinin Park Süresi:");
            double musteri3Saat = Convert.ToDouble(Console.ReadLine());
            

            if (musteri3Saat <= 3)
            {
                musteri3Ucret = minimumUcret;
                Console.WriteLine(musteri3Ucret);
            }
            if (musteri3Saat <= 24)
            {
                musteri3Ucret = minimumUcret + (musteri3Saat - 3) * saatUcreti;
                Console.WriteLine($"ücret 3:{musteri3Ucret}$");
            }
            double TotalÜcret;

            TotalÜcret= musteri1Ucret+musteri2Ucret+musteri3Ucret;
            Console.WriteLine($"TOPLAM ÜCRET:{ TotalÜcret}");
            Console.ReadLine();




            
        }
    }
}
