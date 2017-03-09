using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sal = new ArrayList(5);
            int a;
            Console.WriteLine("Enter the salary");
            for (int i = 0; i < 5; i++)
            {
                a = int.Parse(Console.ReadLine());
                sal.Add(a);
            }
            sal.Sort();
            Console.WriteLine("Values after Sort are");
            foreach (int i in sal)
            {
                Console.WriteLine(i);
            }
            sal.Reverse();

            Console.WriteLine("Values after Reverse are");
            foreach (int i in sal)
            {
                Console.WriteLine(i);
            }
            int x;
            Console.WriteLine("Enter the index to be delete");
            x = int.Parse(Console.ReadLine());
            sal.RemoveAt(x);
            Console.WriteLine("Values after Delete are");
            foreach (int i in sal)
            {
                Console.WriteLine(i);
            }
            int z, val;
            Console.WriteLine("Enter the index to be replace");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value to be replaced");
            val = int.Parse(Console.ReadLine());
            sal.Insert(z, val);
            Console.WriteLine("Values after Insert are");
            foreach (int i in sal)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
