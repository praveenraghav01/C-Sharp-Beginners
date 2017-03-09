using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public delegate void Mydel();
    //public delegate void mydel1();
    class Program
    {
        public void mes1()
        {
            Console.WriteLine("Msg 1");
        }
        public void mes2()
        {
            Console.WriteLine("Msg 2");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Mydel del = new Mydel(p.mes1);
            Mydel del1 = new Mydel(p.mes2);
            Mydel del2 = del + del1;
            del2();
            Console.ReadKey();
        }
    }
}
