using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    interface iCal
    {
        void sum();
        void sub();
        void mul();
        void div();
    }
    class Program:iCal
    {
        public int a, b, c;
        public void sum()
        {
            Console.WriteLine("Enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum is:\t"+c);
        }
        public void sub()
        {
            Console.WriteLine("Enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = int.Parse(Console.ReadLine());
            c = a - b;
            Console.WriteLine("Sub is:\t" + c);
        }
        public void mul()
        {
            Console.WriteLine("Enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = int.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine("Mul is:\t" + c);
        }
        public void div()
        {
            Console.WriteLine("Enter the value of a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = int.Parse(Console.ReadLine());
            c = a / b;
            Console.WriteLine("Div is:\t" + c);
        }
        static void Main(string[] args)
        {
            iCal p = new Program();
            Console.WriteLine("Enter your choice \n1.Sum\n2.Sub\n3.Mul\n4.Div");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1: p.sum();
                    break;
                case 2: p.sub();
                    break;
                case 3: p.mul();
                    break;
                case 4: p.div();
                    break;
                default:
                    Console.WriteLine("You have enter wrong choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
