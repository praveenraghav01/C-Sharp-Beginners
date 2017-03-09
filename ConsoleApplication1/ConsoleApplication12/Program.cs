using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sal;
            string name;
            int da, hr,totalsal;
            Console.WriteLine("Enter the Basic Details \n1.Name \n2.Salary");
            name = Console.ReadLine();
            sal = int.Parse(Console.ReadLine());
            if (sal <= 2000)
            {
                da = (sal * 10) / 100;
                hr = (sal * 20) / 100;
                totalsal = sal + da + hr;
                Console.WriteLine(name + " Your Total Salary is:\t" + totalsal);
            }
            else if (sal > 2000 && sal<=5000)
            {
                da = (sal * 20) / 100;
                hr = (sal * 30) / 100;
                totalsal = da + hr + sal;
                Console.WriteLine(name + " Your Total Salary is:\t" + totalsal);
            }
            else if (sal > 5000 && sal<=10000)
            {
                da = (sal * 30) / 100;
                hr = (sal * 40) / 100;
                totalsal = hr + da + sal;
                Console.WriteLine(name + " Your Total Salary is:\t" + totalsal);
            }
            else if(sal>10000)
            {
                da = (sal * 50) / 100;
                hr = (sal * 50) / 100;
                totalsal = sal + da + hr;
                Console.WriteLine(name + " Your Total Salary is:\t" + totalsal);
            }
            else
            {
                Console.WriteLine("Enter a Numeric Value!!!");
            }
            Console.ReadKey();

        }
    }
}
