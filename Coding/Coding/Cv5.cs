using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class Cv5
    {
        static void Main(string[] args)
        {
            int cislo = 37 ;

            while (cislo != 0)
            {
                if (cislo - 10 >= 10)
                {
                    Console.WriteLine("1234567890");
                    cislo = cislo - 10;

                } 
                else
                {
                    for (int i = 1; i < cislo; i++)
                    {
                        if (i == cislo)
                        {
                            cislo = 0;
                        }
                        else
                        {
                            Console.Write(i + 1);
                        }
                    }
                }





            }

            Console.ReadKey();

            

        }

    }
}
