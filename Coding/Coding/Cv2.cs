using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class Cv2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadejte číslo [1-9]");

            string cislo = Console.ReadLine();

            int num = Int32.Parse(cislo);


            if (num >= 1 && num <= 9)
            {
                for (int i = 1; i < num+1; i++)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i);

                    }

                    Console.WriteLine("");
                }
            } else
            {
                Console.WriteLine("Číslo je mino zadaný rozsah");
            }

            Console.ReadLine();
        }

    }
}
