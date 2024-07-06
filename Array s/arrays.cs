//#define SINGLE_DIMENSION_ARRAYS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_s
{
    internal class arrays
    {
        static void Main(string[] args)
        {

            //1)single dimensional
            //2)multi dimensional
            //3)Jagged

#if SINGLE_DIMENSION_ARRAYS
            Console.Write("Введите размер массива ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Random random = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = random.Next(0,20);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

#endif 


            Random rand = new Random();
            int size = 10, Limit = 100;
            int[] SDarr = new int[size];
            for (int i = 0; i < SDarr.Length; i++)
            {
                SDarr[i] = rand.Next(Limit);
                Console.Write(SDarr[i] + " ");
            }
            Console.WriteLine();
            int sum = 0, min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < SDarr.Length; i++)
            {
                sum += SDarr[i];
                if (min > SDarr[i])
                {
                    min = SDarr[i];
                }
                if (max < SDarr[i])
                {
                    max = SDarr[i];
                }
            }
            double arithmeticMean = sum / (double)size;
            Console.WriteLine($"Sum = {sum}\nArithmetic Mean =  {arithmeticMean}\nMin = {min}\nMax = {max} ");



        }
    }
}
