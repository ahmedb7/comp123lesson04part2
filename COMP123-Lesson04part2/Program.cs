using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04part2
{
    class Program
    {
        static void Main(string[] args)
        {
            hero myHero = new hero(7, 8, "female");
            myHero.doesGoodThings();

            //Wait for input
            Console.WriteLine("Press any key to exit:");
            Console.ReadKey();
        }
    }
}
