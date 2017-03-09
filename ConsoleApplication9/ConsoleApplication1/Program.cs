using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void Mydel(int i);
    class Program
    {
        int count = 0;
        public event Mydel evnt;
        public void cal(int i)
        {
            int x = i;
            while (i!=0)
            {
                i = i / 10;
                count++;
            }
            if (count==5)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Mydel del = new Mydel(p.cal);
            p.evnt += del;
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            p.evnt.Invoke(a);
            Console.ReadKey();
        }
    }
}
