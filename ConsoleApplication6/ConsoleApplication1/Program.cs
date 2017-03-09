using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        int number;
        public int NUMBER
        {
            get
            {
                return number;
            }
            set
            {
                if(value>=0)
                {
                    number = value; 
                }
                else
                {
                    Console.WriteLine("Enter positive number");
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the number");
            p.NUMBER = int.Parse(Console.ReadLine());
            Console.WriteLine("Number is:\t"+p.NUMBER);
            Console.ReadKey();
        }
    }
}
