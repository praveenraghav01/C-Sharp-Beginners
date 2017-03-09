using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface a
    {
        void abc();
    }
    interface b : a
    {
        void xyz();
    }
    class Program:b
    {
        public void abc()
        {
            Console.WriteLine("abc called");
        }
        public void xyz()
        {
            Console.WriteLine("xyz Called");
        }
        static void Main(string[] args)
        {
            b p = new Program();
            p.xyz();
            p.abc();
            Console.ReadKey();
        }
    }
}
