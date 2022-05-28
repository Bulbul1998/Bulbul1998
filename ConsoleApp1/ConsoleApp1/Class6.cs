using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class6
    {
       static void Main7(string[] args)
        {
            Console.WriteLine("Enter the 1st value");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("output");
            while (m <= n)
            {
                Console.WriteLine(m);
                m++;
            }
        }
    }
}
