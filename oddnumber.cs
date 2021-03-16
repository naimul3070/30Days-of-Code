using System;
using System.Collections.Generic;
using System.Text;

namespace NaimulIsam
{
    class oddnumber
    {
        static void Main(string[] args)
        {
            int a = 57;

            int count = 0;
            for(int i = 2; i < a; i++)
            {
                if (a% 1 == 0)
                {
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("prime");
            else
                Console.WriteLine("Not Prime");


            Console.ReadKey();
        }
    }
}
