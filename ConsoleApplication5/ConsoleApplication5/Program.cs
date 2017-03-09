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
            string str;
            String str1="";
            int i;
            Console.WriteLine("Enter the string");
            
            str = Console.ReadLine();
            for(i=str.Length-1;i>=0;i--)
            {
                str1+= str[i];
            }
            if (str1==str)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not a Palindrom");
            }
            Console.ReadKey();
            
        }
    }
}
