//#define INTEGRAL_TYPE
//#define FLOATING_TEPE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class dataTypes
    {
        static readonly string delimetr = "\n----------------------------------------\n";
        static void Main(string[] args)
        {
#if INTEGRAL_TYPE
            Console.WriteLine("short");
            short _short= 0;
             Console.WriteLine($"класс-обверка: {_short.GetType()} ");
            Console.WriteLine($"значение {sizeof(short)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{short.MinValue}.....{short.MaxValue}");
            Console.WriteLine(delimetr);

            ushort _ushort= 0;
            Console.WriteLine("ushort");
            Console.WriteLine($"класс-обверка: {_ushort.GetType()} ");
            Console.WriteLine($"значение {sizeof(ushort)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{ushort.MinValue}.....{ushort.MaxValue}");
            Console.WriteLine(delimetr);

            int _int=0;
            Console.WriteLine("int");
            Console.WriteLine($"класс-обверка: {_int.GetType()} ");
            Console.WriteLine($"значение {sizeof(int)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{int.MinValue}.....{int.MaxValue}");
            Console.WriteLine(delimetr);

            uint _uint= 0;
            Console.WriteLine("uint");
            Console.WriteLine($"класс-обверка: {_uint.GetType()} ");
            Console.WriteLine($"значение {sizeof(uint)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{uint.MinValue}.....{uint.MaxValue}");
            Console.WriteLine(delimetr);


            ulong _ulong= 0;
            Console.WriteLine("ulong");
            Console.WriteLine($"класс-обверка: {_ulong.GetType()} ");
            Console.WriteLine($"значение {sizeof(ulong)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{ulong.MinValue}.....{ulong.MaxValue}");
            Console.WriteLine(delimetr);

            long _long= 0;
            Console.WriteLine("long");
            Console.WriteLine($"класс-обверка: {_long.GetType()} ");
            Console.WriteLine($"значение {sizeof(long)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{long.MinValue}.....{long.MaxValue}");
            Console.WriteLine(delimetr); 
#endif

#if FLOATING_TEPE
            //float double and decimal

            Console.WriteLine("float");
            Console.WriteLine($"значение {sizeof(float)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{float.MinValue}.....{float.MaxValue}");
            Console.WriteLine(delimetr);

            Console.WriteLine("double");
            Console.WriteLine($"значение {sizeof(double)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{double.MinValue}.....{double.MaxValue}");
            Console.WriteLine(delimetr);

            Console.WriteLine("decimal");
            Console.WriteLine($"значение {sizeof(decimal)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{decimal.MinValue}.....{decimal.MaxValue}");
            Console.WriteLine(delimetr);

            Console.WriteLine("bool");
            Console.WriteLine($"значение {sizeof(bool)} байта ");

            Console.WriteLine(delimetr);

            Console.WriteLine("char");
            Console.WriteLine($"значение {sizeof(char)} байта ");
            Console.WriteLine($"диапозон примаемых значений :{char.MinValue}.....{char.MaxValue}");
            Console.WriteLine(delimetr);
#endif


            int a = 2;
            uint b = 3;
            a = (int)b;
            Console.WriteLine((a+b).GetType());

        }
    } 
}