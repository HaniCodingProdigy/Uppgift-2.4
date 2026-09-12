using System;
namespace övning2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många dagar ska du hyra bilen");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många Kilometer ska du köra med bilen");
            int km = int.Parse(Console.ReadLine());
            int summa = 300 + km + (500 * (dagar - 1));
            Console.WriteLine("den total kostnaden är " + summa);
        }
    }
}