using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int j = 0;
            
            int d = a;
            for (int i = 0; i < 5; i++)
            {
               int s = a % 10;
                j = j* 10 + s;
                a = a / 10;

            }
            if(d==j)
            {
                Console.WriteLine("Number is Palindrom");
            }
            else
            {
                Console.WriteLine("Number is not Palindrom");
            }
            Console.ReadKey();
        }
    }
}
