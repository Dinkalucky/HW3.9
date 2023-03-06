using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task9._3
{
    public delegate int MyDelegate();

        class Program
        {
            private static int NumbersGenerator()
            {
                Random random = new Random();
                int i = random.Next(1, 12);
                Console.WriteLine(i);
                return i;
            }

             static void Main(string[] args)
             {
                 int sum = 0;
                 MyDelegate[] delsArray = {
                     NumbersGenerator, NumbersGenerator, NumbersGenerator, NumbersGenerator, NumbersGenerator
                 };

                 for (int i = 0; i < delsArray.Length; i++)
                 {
                    sum += delsArray[i]();
                    Thread.Sleep(150);
                 }
                 Console.WriteLine($"{sum} / {delsArray.Length} = {sum/delsArray.Length}");

            Console.ReadKey();
             }
        }
    
}
