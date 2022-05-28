using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class10
    {
        static void Main(string[] args)
        {
            int x=5,  y=6;
           Console.WriteLine("Before swapping\na=  "+ x + "b= "+ y);
            Swap(x,y);
           Console.WriteLine("After swapping\na= " + x + "b= "+ y);

        }
        static void Swap(int a,int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a= " +a+ "b= "+b);
        }
    }
}
