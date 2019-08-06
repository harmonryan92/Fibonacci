using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClass
{
    class HW_Fibonacci
    {
        static int getFibonacci(int n)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 1; i <= n; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }
        static void Main(string[] args)
        {
            int userEntry;          

            Console.WriteLine("What position in the Fibonacci sequence would you like to see?");
            while (!int.TryParse(Console.ReadLine(), out userEntry) || userEntry < 0 )
            {
                Console.WriteLine("Invalid input. Enter a positive number.");
            }

            Console.WriteLine("The value at position {0} is {1}", userEntry, getFibonacci(userEntry));                              
        }
    }
}
