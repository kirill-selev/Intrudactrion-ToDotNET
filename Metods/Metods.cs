using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    internal class Metods
    {
        static void Main(string[] args)
        {
            //int len=args.Length;
            //int[] arr = new int[] {};
            //foreach (string i in args)
            //{
            //    Console.WriteLine(i + "\t");
            //}
            List<int> L_numbers = new List<int>();
            foreach (string i in args)
            {
                L_numbers.Add(Convert.ToInt32(i));

            }
            Console.WriteLine(Sum(L_numbers.ToArray()));

            int a , b ;
            Input(out a ,out  b );
            Console.WriteLine($"{a}\t{b}");
            Exchange(ref a, ref b);
            Console.WriteLine($"{a}\t{b}");
        }
        static void Input( out int a, out  int b)
        {
            Console.Write("Введите значение переменной 'a':");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение переменной 'b':");
            b = Convert.ToInt32(Console.ReadLine());
        }
        static int Sum(params int[] numbers)
        {

            int sum = 0;
            foreach (int i in numbers) sum += i;
            return sum;

        }

        static void Exchange(ref int a, ref int b)
        {
            int buffer = a;
            a = b;
            b = buffer;
        }

    }

}
