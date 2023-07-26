using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AylaraGoreMevsimler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Finding a season according to the number between 1 - 12 ***
            
            int number;
           
            Console.WriteLine("Please enter a number between 1 - 12");
            number = Convert.ToInt16(Console.ReadLine());

            if (number >= 3 && number <= 5)
            {
                Console.WriteLine("The season is : Spring");
            }
            else if (number >= 6 && number <= 8)
            {
                Console.WriteLine("The season is : Summer");
            }
            else if (number >= 9 && number <= 11)
            {
                Console.WriteLine("The season is : Fall");
            }
            else if (number >= 1 && number <= 12)
            {
                Console.WriteLine("The season is : Winter");
            }
            else
            {
                Console.WriteLine("You should enter a number between 1 - 12");
            }


            Console.Read();
        }
    }
}
