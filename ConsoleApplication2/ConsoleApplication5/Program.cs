using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public void prime(int n)
        {
            while (n%2==0)
            {
                Console.WriteLine("2,");
                n = n / 2;
            }
            for (int i = 3; i <=sqrt(n); i+2)
            {

            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Program p = new Program();
            p.prime(n);
        }
    }
}
