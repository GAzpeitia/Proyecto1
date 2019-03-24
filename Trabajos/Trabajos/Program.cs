using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2 = 0;
            string let = " ";

            Console.WriteLine("Ingresa un número");
            num = int.Parse(Console.ReadLine());

           // do
            //{
                for (int a = 1; a <= num; a++)
                {
                let = "*";
                //Console.WriteLine(let);
                for (string b = "*"; b <= a; b = b + "*")
                {
                    Console.WriteLine(let);
                }
                
            }


            //} while (num2 == num);
            Console.ReadKey();
        }
    }
}
