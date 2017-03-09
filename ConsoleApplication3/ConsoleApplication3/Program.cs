using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        Program()
        {
            Console.WriteLine("Contructor called");
        }
        ~Program()
        {
            Console.WriteLine("Distructor called");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadKey();

        }
    }
}
