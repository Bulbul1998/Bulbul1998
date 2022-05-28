using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class9
    {
        static void Main10(string[] args)
        {  //             
            int[] arr = { 2, 2};
            int size = arr.Length;//2
            
            for(int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                int pw = size;
                int rev = 1;
                while (pw > 0)
                {
                    res = res * num;
                    pw--;
                }
                Console.WriteLine(res);
            }
        }
    }
}