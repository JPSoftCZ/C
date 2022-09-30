using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class Cv6
    {

        static void Main(string[] args)
        {
            printNumbers(7);
            
        }

        static void printNumbers(int number)
        {
            for (int i = 1; i < number+1; i++)
            {
                Console.Write("[ " + i + " ]");
            }

            Console.ReadKey();

        }
        

            
    }
}
