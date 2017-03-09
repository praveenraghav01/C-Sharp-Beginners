using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public void swapval(int a, int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swap Value of a:{0}\tand b:{1}",a,b);
        }
        public void swapref(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Value of a:{0}\tand b:{1}", a, b);
        }
        static void Main(string[] args)
        {
            int a=10, b=20;
            Program p = new Program();
            Console.WriteLine("Value of a:{0}\tand b:{1}", a, b);
            p.swapval(a, b);
            Console.WriteLine("Value ref of a:{0}\tand b:{1}", a, b);
            p.swapref(ref a, ref b);
            Console.ReadKey();
        }
    }
}
