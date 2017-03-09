using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No\tSqure\tCube");
            for (int i = 0; i < 11; i++)
            {
                int a, b;
                a = i * i;
                b = i * i * i;
                Console.WriteLine(i + "\t" + a + "\t" + b);

            }
            Console.ReadKey();
        }
    }
}
