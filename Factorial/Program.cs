using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (uint i = 0; i < 100; i++) { Console.WriteLine($"{i}! = {Factorial(i)}"); }


        }
        static string Factorial(uint num)
        {
            string result = "1";
            if (num <= 0) return result;
            else return Multiply(num.ToString(), Factorial(num - 1).ToString());
        }
        static string Multiply(string operand1, string operand2)
        {
            int multiplication;
            int sum;
            int[] result = new int[operand1.Length + operand2.Length];
            for (int i = operand1.Length - 1; i >= 0; i--)
            {
                for (int j = operand2.Length - 1, v = 0; j >= 0; j--, v++)
                {
                    multiplication = (operand1[i] - '0') * (operand2[j] - '0');
                    sum = multiplication + result[result.Length - 1 - v - (operand1.Length - 1 - i)];

                    result[result.Length - 1 - v - (operand1.Length - 1 - i)] = sum % 10;
                    result[result.Length - 2 - v - (operand1.Length - 1 - i)] += sum / 10;
                }
            }
            string str = "";
            bool flag = false;
            for (int i = 0; i < result.Length; i++)
            {
                if (!flag && result[i] == 0)
                {
                    continue;
                }
                else
                {
                    flag = true;
                }
                str += result[i].ToString();
            }
            return str;
        }
    }
}
