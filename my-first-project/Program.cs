using System;
using System.Xml.Schema;

namespace my_first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number:");
            int sum1 =int.Parse(Console.ReadLine());
            Console.Write("enter second number:");
            int sum2 =int.Parse(Console.ReadLine());
            int result  = sum1 + sum2;
            string word = result.ToString();
            Console.WriteLine("result is " +word );
        }
    }
}