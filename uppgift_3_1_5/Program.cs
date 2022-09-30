using System;
namespace Uppgift_3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen");
            int timmar = int.Parse(Console.ReadLine());
            int h = 80;

            if (timmar <= 11)
            {
                Console.WriteLine(   "Du ska betala "+timmar * h + "kr");

            }
            else if (timmar >= 12)
            {
                Console.WriteLine(" Du får inte hyra bilen mer än 12 timmar per dag ");
            }
        }
    }
}
