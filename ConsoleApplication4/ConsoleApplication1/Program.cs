using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int min=0, max=0;
            Console.WriteLine("Enter the 10 values ");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (arr[i]>arr[i+1])
                {
                     max = arr[i];
                }
                else
                {
                     min = arr[i];
                }
            }
            Console.WriteLine("hig"+max+"low"+min);
            Console.ReadKey();
        }
    }
}
