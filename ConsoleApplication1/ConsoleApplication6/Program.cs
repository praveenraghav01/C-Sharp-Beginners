using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine()); 
            int d,e,f;
            d = (a < b) ? a : b;
            e = (a < c) ? a : c;
            f = (d < e) ? d : e;
            Console.WriteLine("Smallest is:" + f);
            Console.ReadKey();
        }
    }
}
