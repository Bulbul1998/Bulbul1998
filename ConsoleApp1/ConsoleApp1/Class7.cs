using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class7
    {
        static void Main8(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine(arr[1]);

            Console.WriteLine(arr[2]);
            arr[2] = 34;
            Console.WriteLine(arr[2]);
            Console.WriteLine("size" + arr.Length);
            Console.WriteLine("Index" + (arr.Length - 1));
        }
    }
}
