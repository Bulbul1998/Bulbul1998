using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main2(string[] args)
        {
            int u; 
            Console.Write("\n\n");
            Console.Write("age of voting");
            Console.Write("--------");
            Console.Write("\n\n");
            Console.Write("write the input of condidate");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            while (m > 0)
            {
                int dig = m % 10;
                Console.Write(dig);
                m = m / 10;

            }


        }



    }
}
