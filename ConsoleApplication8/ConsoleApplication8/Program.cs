using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList pn = new ArrayList();
            ArrayList pna = new ArrayList();
            ArrayList pp = new ArrayList();
            Console.WriteLine("ENter the Product number");
            int[] arrr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arrr[i] = int.Parse(Console.ReadLine());
                pn.Add(arrr[i]);
            }
            //Console.WriteLine("ENter the Product name");
            //for (int i = 0; i < 5; i++)
            //{
            //    pna.Add(Console.ReadLine());
            //}
            //Console.WriteLine("ENter the Product Price");
            //for (int i = 0; i < 5; i++)
            //{
            //    pp.Add(Console.ReadLine());
            //}
            Console.WriteLine("Values are");
            foreach(int i in pn)
            {
                Console.WriteLine(i);
            }
            int a,val;
            Console.WriteLine("Enter the index to be replace");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value to be replaced");
            val = int.Parse(Console.ReadLine());
            pn.Insert(a, val);
            Console.WriteLine("Values are");
            foreach (int i in pn)
            {
                Console.WriteLine(i);
            }
            int x;
            Console.WriteLine("Enter the index to be delete");
            x = int.Parse(Console.ReadLine());
            pn.RemoveAt(x);
            Console.WriteLine("Values are");
            foreach (int i in pn)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
