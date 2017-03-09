using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int billno;
            string name;
            int val;
            int price;
            int choice;
            Console.WriteLine("Enter Your Choice:-\n1.New Item\n2.Calculate Bill");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1 : Console.Write("\n\n\nEnter Billno:-\t");
                         billno = int.Parse(Console.ReadLine());
                    Console.Write("Enter Your Name:-\t");
                    name = Console.ReadLine();
                    Console.Write("Enter Value:-\t");
                    val = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price:-\t");
                    price = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n\nBillno:\t" + billno + "\nName:\t" + name + "\nValue:\t" + val + "\nPrice:\t" + price);
                    break;
                case 2: Console.Write("\n\n\nEnter Value:-\t");
                        val = int.Parse(Console.ReadLine());
                    Console.Write("Enter Price:-\t");
                    price = int.Parse(Console.ReadLine());
                    int total;
                    total = val * price;
                    Console.WriteLine("\n\n\nTotal Bill:\t"+ total);
                    break;
                default: Console.WriteLine("\n\n\n Enter either 1 or 2!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
