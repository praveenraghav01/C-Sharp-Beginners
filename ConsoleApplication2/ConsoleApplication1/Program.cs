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
            int d=0;
            int s;
            Console.WriteLine("Perfect Numbers B/W 1to 500");
            for (int i = 1; i <=500; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        d = d + j;

                       // Console.WriteLine(d);
                    }
                    else
                    {
                        continue;
                    }
                }
                if(i==d)
                {
                    Console.WriteLine(1);
                  
                }
                else
                {
                    continue;
                }
                d = 0;
            }
            Console.ReadKey();
        }
    }
}
