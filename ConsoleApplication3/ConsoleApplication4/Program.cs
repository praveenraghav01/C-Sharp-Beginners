using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public void cal(int x,int y,out int sum,out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        int total(int num1,int num2=12)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int x = 20, y = 30,sum,sub;
            p.cal(x, y, out sum, out sub);
            Console.WriteLine("Sum is :{0}\tSub is :{1}",sum,sub);
            Console.WriteLine("\n\n\n");
            int a = p.total(num1: 20, num2: 20);
            Console.WriteLine(a);
            Console.ReadKey();
        }

    }
}
