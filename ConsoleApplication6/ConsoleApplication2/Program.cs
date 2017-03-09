using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    namespace FIRST
    {
        class abc
        {
            public int i, j, k;
        }
        namespace SECOND
        {
            public class xyz
            {
                int i = 40, j = 50, k = 60;
               public int s = 0, z = 1;
              public  xyz()
                {
                    s = i + j + k;
                    z = i * j * k;
                    Console.WriteLine("Sum:\t{0}\nProduct:\t{1}",s,z);
                    Console.ReadKey();
                }

            }
            class asd
            {
                static void Main(string[] args)
                {


                    ConsoleApplication2.FIRST.SECOND.xyz obj = new ConsoleApplication2.FIRST.SECOND.xyz();
                }
                
            }
           


        }

       
    }
}
