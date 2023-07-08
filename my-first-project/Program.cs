using System;
using System.Xml.Schema;

namespace my_first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter three number:");
            int num = int.Parse(Console.ReadLine ());
            //Console.WriteLine(value / 100);
            switch(num)
            {
                case<10:
                    Console.WriteLine(num);
                    break;
                case<100:
                    Console.WriteLine(num / 10);
                    break;
                case<1000:
                    Console.WriteLine(num / 100);
                    break;
                case<10000:
                    Console.WriteLine(num / 1000);
                    break;
                default:
                    Console.WriteLine("enter below tenthousand");
                    break;
                
          
                    
            }   
        }
    }
}