//#define Done
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworck
{


    internal class Program
    {

        static void Main(string[] args)
        {
#if Done
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5 - i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
                    {
                        Console.Write("+");
                    }

                    else
                    {
                        Console.Write("-");
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine(); 
#endif

        }
    }



 }
