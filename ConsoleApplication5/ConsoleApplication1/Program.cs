using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            
            if (str.Contains('a'))
            {
                Console.WriteLine(str.Substring(1,1));
            }

            if (str.Contains('e'))
            {
                Console.WriteLine(str.Substring(1, 1));
            }

            if (str.Contains('i'))
            {
                Console.WriteLine(str.Substring(1, 1));
            }

            if(str.Contains('o'))
            {
                Console.WriteLine(str.Substring(1, 1));
            }

            if (str.Contains('u'))
            {
                Console.WriteLine(str.Substring(1, 1));
            }

            Console.ReadKey();
        }
    }
}
