using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s=1, j = 1;
            Console.WriteLine("Enter the Number");
            int a = int.Parse(Console.ReadLine());
            while (a!=0)
            {
                s = a % 10;
                j = j * s;
                a = a / 10;
            }
            Console.WriteLine("Answer is:\t" + j);
            Console.ReadKey();
        }
    }
}
