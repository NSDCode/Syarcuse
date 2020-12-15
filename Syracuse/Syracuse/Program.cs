using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syracuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number of terms:");
            int it = int.Parse(Console.ReadLine());
            Console.Write("Please input a initial value:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < it; i++)
            {
                if (IsPair(x))
                {
                    x = x / 2;
                }
                else
                {
                    x = x * 3 + 1;
                }
                Console.WriteLine($"U{i} = {x}");
            }
            Console.ReadLine();
        }

        public static bool IsPair(int x)
        {
            return x % 2 == 0;
        }
    }
}
