using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class person
    {
        public int age;
        public string name;
        public string gen;
        public void getdata()
        {
            Console.WriteLine("Enter the Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Gender");
            gen = Console.ReadLine();
        }
    }
    class emp:person
    {
        public int code;
        public void coder()
        {
            Console.WriteLine("Enter the code");
            code = int.Parse(Console.ReadLine());
        }

    }
    class spe:emp
    {
        public string spes;
        public void spese()
        {
            Console.WriteLine("Enter specilization");
            spes = Console.ReadLine();
        }
    }
    class Program:spe
    {
        public void setdata()
        {
            Console.WriteLine("Enterd Details are\nName:\t{0}\nAge:\t{1}\nGender:\t{2}\nEmp Code:\t{3}\nSpecilization:\t{4}",name,age,gen,code,spes);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.getdata();
            p.coder();
            p.spese();
            p.setdata();
            Console.ReadKey();
        }
    }
}