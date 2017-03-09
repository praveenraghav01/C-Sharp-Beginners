using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable(3);
            h.Add("Raghav", "Raghavasd");
            h.Add("asd", "asdas");
            h.Add("smith", "smithas");
            Console.WriteLine("Enter the Username");
            string us = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pas = Console.ReadLine();
            if (h.ContainsKey(us)&&h.ContainsValue(pas))
            {
                Console.WriteLine("\n\n\nLogIn ");
                Console.WriteLine("\nWelcome\t{0}\n\nYour Password is\t{1}",us,pas);
            }
            else
            {
                Console.WriteLine("\n\nWrong Username or Password");
            }
            Console.ReadKey();
        }
    }
}
