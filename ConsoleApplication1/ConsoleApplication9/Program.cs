using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f=f* i;
            }
            Console.WriteLine("Factorial is:" + f);
            Console.ReadKey();
        }
    }
}
