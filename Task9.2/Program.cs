using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task9._2.Program;

namespace Task9._2
{
    internal class Program
    {
        public delegate void MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyDelegate Add, Sub, Mul, Div;
            int x, y;
            string dia;

            Console.WriteLine("Введіть перше число: ");
            Int32.TryParse(Console.ReadLine(), out x);

            Console.WriteLine("Введіть друге число: ");
            Int32.TryParse(Console.ReadLine(), out y);

            Console.WriteLine("Яку дію над числами ви хотіли б виконати?");
            dia = Console.ReadLine();

            Add = (a,b) => { Console.WriteLine($"{a} + {b} = {a + b}"); };
            Sub = (a, b) => { Console.WriteLine($"{a} - {b} = {a - b}"); };
            Mul = (a, b) => { Console.WriteLine($"{a} * {b} = {a * b}"); };
            Div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("На нуль ділити не можна!");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {a / b}");
                }
                
            };

            switch (dia)
            {
                case "Add":
                    Add(x, y); break;
                case "Sub":
                    Sub(x, y); break;
                case "Mul":
                    Mul(x, y); break;
                case "Div":
                    Div(x, y); break;

            }

            Console.ReadLine();

        }
    }
}
