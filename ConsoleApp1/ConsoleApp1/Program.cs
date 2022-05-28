using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main1(string[] args)
        {
            int a = 1974;
            
          
            while (a > 0)
            {
                int dig = a % 10;
                if (dig % 2 == 0)
                {
                    Console.WriteLine("Even Number" + dig);
                }
                else
                {
                    Console.WriteLine("odd Number" + dig);
                }
                a = a / 10;

            }
            
            
              
           
        }
    }
}
