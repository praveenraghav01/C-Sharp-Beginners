using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
       
           public int[] id=new int[5];
           public string[] name=new string[5];
           public int[] sal=new int[5];
            public void getdata()
            {
            for (int i = 0; i < 2; i++)
            {

            
                    Console.WriteLine("Enter the details of  Emp");
                    Console.WriteLine("Enter id");
                    id[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the name");
                    name[i] = Console.ReadLine();
                    Console.WriteLine("Enter the salary");
                    sal[i] = int.Parse(Console.ReadLine());
            }
        }
            public void setdata()
            {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Emp id is " + id[i]);
                Console.WriteLine("Emp name is " + name[i]);
                Console.WriteLine("Emp sal is " + sal[i]);
            }                

            }
        public void sear()
        {
            int val,flag=0;
            Console.WriteLine("Enter id to be searched");
            val = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                if (val == id[i])
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag==1)
            {
                Console.WriteLine("Found");

            }
            else
            {
                Console.WriteLine("not found");
            }
        }
       

        public static void Main(string[] args)
        {
             
            Program p = new Program();
            p.getdata();
            Console.WriteLine("\n\n");
            p.setdata();
            Console.WriteLine("\n\n");
            p.sear();
           
            
           
            Console.ReadKey();
        }
    }
}
