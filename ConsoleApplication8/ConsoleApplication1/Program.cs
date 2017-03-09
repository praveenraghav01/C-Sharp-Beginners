using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            Console.WriteLine("Enter the details\n1.Key\n2.Value");
            for (int i = 0; i < 5; i++)
            {
                int a = int.Parse(Console.ReadLine());
                string b = Console.ReadLine();
                h.Add(a, b);
            }
            foreach (DictionaryEntry d in h)
            {
                Console.WriteLine("key:\t{0}\tValues:\t{1}",d.Key,d.Value);
            }
            Console.ReadKey();
        }
    }
}
