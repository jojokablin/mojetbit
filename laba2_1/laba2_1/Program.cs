using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            //enter sigh


            int c = a - b;
           

            int e = a * b;
   

            Console.WriteLine("Результат сложения {0}", c);
            Console.ReadKey();
        }
    }
}
