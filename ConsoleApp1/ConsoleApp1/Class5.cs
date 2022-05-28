using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class5
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("square of the number");

            Console.WriteLine("Enter the 1st number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int n = Convert.ToInt32(Console.ReadLine());
            long res = 1;
            while (n > 0)
            {
                res = res * m;
                n--;
            }
            Console.WriteLine("result" + res);
            Console.ReadLine();
        }
    }
}

