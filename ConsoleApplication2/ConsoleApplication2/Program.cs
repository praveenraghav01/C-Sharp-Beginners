using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;
            Console.WriteLine("Enter Your Choice:\n1.Add\n2.Sub\n3.Mul\n4.Div");
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Enter two numbers");
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    d = b + c;
                    Console.WriteLine("Answer is:" + d);
                    break;
                case 2:
                    Console.WriteLine("Enter two numbers");
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    d = b - c;
                    Console.WriteLine("Answer is:" + d);
                    break;
                case 3:
                    Console.WriteLine("Enter two numbers");
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    d = b * c;
                    Console.WriteLine("Answer is:" + d);
                    break;
                case 4:
                    Console.WriteLine("Enter two numbers");
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    d = b / c;
                    Console.WriteLine("Answer is:" + d);
                    break;
                default: Console.WriteLine("Wrong Input!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
