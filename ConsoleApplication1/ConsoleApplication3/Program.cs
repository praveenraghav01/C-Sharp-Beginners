using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
       public enum week {Sun,Mon,Tue,Wed,Thur,Fri,Sat};
        static void Main(string[] args)
        {
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case (int)week.Sun:Console.WriteLine("Sun");
                    break;
                case (int)week.Mon:Console.WriteLine("Mon");
                    break;
                case (int)week.Tue:Console.WriteLine("Tue");
                    break;
                case (int)week.Wed:Console.WriteLine("Wed");
                    break;
                case (int)week.Thur:Console.WriteLine("Thur");
                    break;
                case (int)week.Fri:Console.WriteLine("Fri");
                    break;
                case (int)week.Sat:Console.WriteLine("Sat");
                    break;
                default:Console.WriteLine("You have enterd wrong option");
                    break;
            }
            Console.ReadKey();
        }
    }
}
