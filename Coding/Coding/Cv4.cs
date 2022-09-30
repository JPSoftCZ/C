using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class Cv4
    {
        static void Main(string[] args)
        {
            int cislo = 5;

            for (int i = 1; i < cislo+1; i++)
            {
                for (int j = 0; j < cislo-i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
