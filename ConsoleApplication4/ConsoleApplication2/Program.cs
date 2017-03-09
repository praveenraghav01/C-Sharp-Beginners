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
            int[] ara = new int[15];
            //int flag = 0;
            bool prime=true;
            Console.WriteLine("First five prime numbers are:");
            for (int i = 2; i < 100; i++)
            {
                for (int j=2;j<=i/2;j++)
                {
                    if (i!=j && i%j==0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("\t"+i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
