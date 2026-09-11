using System;
using System.ComponentModel.DataAnnotations;
namespace övning2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många dagar ska du hyra bilen");
            double dagar = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur många Kilometer ska du köra med bilen");
            double km = double.Parse(Console.ReadLine());
            double summa = 300 + km + (500 * (dagar - 1));
            Console.WriteLine("den total kostnaden är " + summa);
        }
    }
}