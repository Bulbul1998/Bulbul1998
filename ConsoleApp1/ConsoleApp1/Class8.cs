using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class8
    {
        static void Main9(string[] args)
        {  //           
            int[] arr= { 10, 43, 56 };
            int sum = 0;
            int prod = 1;
            {                    
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        sum = sum + arr[i];
                    }
                    else
                    {
                        prod = prod * arr[i];
                    }
                    
                    
                }
                Console.WriteLine(sum);
                Console.WriteLine(prod);
            }
        }
    }
}
