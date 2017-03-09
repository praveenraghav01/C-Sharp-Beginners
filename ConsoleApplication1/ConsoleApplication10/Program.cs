using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 0, c = 1 ,d,temp=0;
            Console.Write("0,1,");
            for (int i = 3; i <= a; i++)
            {
                d = b + c;
                Console.Write(d+",");
                temp = c;
                b = c;
                c = d;

            }
            Console.ReadKey();
        }
    }
}
