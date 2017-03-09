using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public void cal(int x, int y, out int sum, out int sub, out int mul,out int div)
        {
            sum = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            int x = 20, y = 2, sum, sub,mul,div;
            p.cal(x, y, out sum, out sub,out mul,out div);
            Console.WriteLine("Sum is :{0}\nSub is :{1}\nMul is :{2}\nDiv is :{3}", sum, sub,mul,div);
            
            Console.ReadKey();
        }
    }
}
