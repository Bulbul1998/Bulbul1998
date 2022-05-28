using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main5(string[] args)
        {
            int a = 127;
            int b = a;
            int rev = 0;
            while(a>0)
            { int c = a % 10; //...121%10===1
                rev = (rev * 10) + c;
                a = a / 10;

            }
            if (b == rev)
            {
                Console.WriteLine("palindrom number" + rev);
            }
            else
            {
                Console.WriteLine("not palindrom number" + rev);
            }
            Console.ReadLine();
        }

    }
}
