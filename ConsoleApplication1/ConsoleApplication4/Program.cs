using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;
            marks = int.Parse(Console.ReadLine());
            switch (marks)
            {   
                default:
                    if (marks <= 33)
                    {
                        Console.WriteLine("Fail");
                    }
                    else if (marks > 33 && marks <= 50)
                    {
                        Console.WriteLine("Poor");
                    }
                    else if (marks > 50 && marks <= 70)
                    {
                        Console.WriteLine("U can do better");
                    }
                    else if (marks > 70 && marks <= 80)
                    {
                        Console.WriteLine("Good");
                    }
                    else if (marks > 80 && marks <= 90)
                    {
                        Console.WriteLine("V.Good");
                    }
                    else if (marks > 90 && marks <= 100)
                    {
                        Console.WriteLine("Awsm");
                    }
                    else
                    {
                        Console.WriteLine("U have enterd wrong input");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
