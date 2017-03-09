using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        int eid;
        string ename;
        int sal;
        string add;
        public void getdata()
        {
            Console.Write("Enter Id:-");
            eid = int.Parse(Console.ReadLine());
            Console.Write("Enter Name:-");
            ename = Console.ReadLine();
            Console.Write("Enter Salary:-");
            sal = int.Parse(Console.ReadLine());
            Console.Write("Enter Address:-");
            add = Console.ReadLine();
        }
        public void putdata()
        {
            Console.WriteLine("\n\n\nId is:\t" + eid);
            Console.WriteLine("Name is:\t" + ename);
            Console.WriteLine("Salary is:\t" + sal);
            Console.WriteLine("Address is:\t" + add+"\n\n\n");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();
            p1.getdata();
            p1.putdata();
            p2.getdata();
            p2.putdata();
            Console.ReadKey();
        }
    }
}
