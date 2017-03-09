using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
        public delegate void Mydel(Array i);
        class Program
        {
            //int count = 0;
            public event Mydel evnt;
            public void cal(Array x)
            {
            Array.Sort(x);
            foreach(int i in x)
            {
                Console.WriteLine(i);
            }
            }
            
            static void Main(string[] args)
            {
                Program p = new Program();
                Mydel del = new Mydel(p.cal);
                p.evnt += del;
           // int[] a = new int[]{ 1, 3, 2, 5, 6 };
            Array ass = new Array[10];
            for (int i = 0; i < 10; i++)
            {
                
            }
            p.evnt.Invoke(ass);
          
            Console.ReadKey();
            }
        }
}
