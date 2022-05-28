using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main3(string[] args)
        {
            sum();
            sub();
        }
        static void sum()
        {
            int a, b, c;
            a = 3;
            b = 6;
            c = a+b;
            Console.WriteLine("c value" + c);
        }
        static void sub()
        {
            int a, b, c;
            a = 5;
            b = 2;
            c = a - b;
            Console.WriteLine("c value" + c);
        }
    }
}
