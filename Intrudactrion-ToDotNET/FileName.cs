#define CLASSCONSOLE
//#define STRINGS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intrudactionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.Title = "Введение в .NET";
            //Console.WriteLine("Hello.NET");
            //Console.BackgroundColor= ConsoleColor.Blue;
            //Console.ForegroundColor= ConsoleColor.Red;
            //Console.CursorLeft = 32;
            //Console.CursorTop = 11;
            //Console.Beep(137,2000);
            //Console.Clear();   

            ////Console.SetCursorPosition(22,11);
            //Console.WriteLine("Привет .NET");
            //Console.ResetColor();

#if STRINGS
            Console.Write("Введите ваше имя ");
            string First_name = Console.ReadLine();

            Console.Write("Введите вышу фамилию ");
            string last_name = Console.ReadLine();

            Console.Write("Введите возраст ");
            int age = Convert.ToInt32(Console.ReadLine());

            #region ConsoleWriteRgion
            /* Console.WriteLine(First_name);
                Console.WriteLine(last_name);
                Console.WriteLine( age);*/

            #endregion


            //Console.WriteLine(string.Format("{0}{1}{2}"));


            //Console.WriteLine($"{last_name}{First_name}{age}");  
#endif



        }
    }
}