using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._5
{
    delegate int Sum(int number1, int number2, int number3);
    internal class Program
    {
        static Sum SomeVar() 
        {
            int result = 0;
            Sum del = delegate(int number1, int number2, int number3)
            {
                result = (number1 + number2 + number3) / 3;
                return result;
            };
            return del;
        }
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть перше число");
            Int32.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введіть друге число");
            Int32.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Введіть третє число");
            Int32.TryParse(Console.ReadLine(), out number3);
            Sum del1 = SomeVar();
            Console.WriteLine($"{number1} + {number2} + {number3} = {del1(number1, number2, number3)}");
            

            Console.ReadLine();
        }
    }
}
