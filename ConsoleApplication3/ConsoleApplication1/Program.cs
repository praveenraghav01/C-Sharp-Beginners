using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        Program(int a)
        {
            double area;
            area = 3.14 * a * a;
            Console.WriteLine("Area of Circle is:\t"+area);
        }
        Program(int a, int b)
        {
            int area;
            area = a * b;
            Console.WriteLine("Area of Rectangle is:\t" + area);
        }
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Program p = new Program(x);
            Program p1 = new Program(x,y);
            Console.ReadKey();
        }
    }
}
