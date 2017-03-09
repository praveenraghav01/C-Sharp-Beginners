using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    { 
        public static void Main(string[] args)
        {
            char s;
            s = char.Parse(Console.ReadLine());
            if (s== 'a' || s== 'e' || s== 'i' || s== 'o' || s== 'u')
            {
                Console.WriteLine("You have enterd a Vowel");
            }
            else
            {
                Console.WriteLine("You have enterd a consonent");
            }
            Console.ReadKey();
        }
    }
}
