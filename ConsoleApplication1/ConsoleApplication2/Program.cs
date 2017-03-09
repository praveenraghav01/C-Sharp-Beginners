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
            int a;
            a = int.Parse(Console.ReadLine());
            int flag = 0;
            
            for (int i = 2; i <=a/2; i++)
            {
                if(a%i==0)
                {
                    flag = 1;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("Number is not Prime");
            }
            else
            {
                Console.WriteLine("Number is Prime");
            }
            Console.ReadKey();
        }
    }
}
