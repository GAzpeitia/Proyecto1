using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajos
{
    class primero
    {
        static void Main(string[] args)
        {
            int num = 0, num2 = 0;

            Console.WriteLine("Ingresa un número");
            num = int.Parse(Console.ReadLine());

                for(int g = 3; g <= num ; g = g + 3)
                {
                    Console.WriteLine(g);
                }
            Console.ReadLine();
            Console.WriteLine("\n____________________________________________");
            for (int k = num; k >= 1; k = k - 3)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
