using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
   public class Base
    {
       public Base(int i)
        {
            Console.WriteLine("Base Cons called");
        }
        ~Base()
        {
            Console.WriteLine("Base dis called");
        }
    }
    public class derive:Base
    {
       public derive():this(12,12)
        {
            Console.WriteLine("Derive cons called");
        }
       public derive(int i,int j):base(1)
        {
            Console.WriteLine("Derive pra called");
         }
        ~derive()
        {
            Console.WriteLine("Derive dis called");
        }
    }

    class Program:derive
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadKey();
        }
       
    }
}
