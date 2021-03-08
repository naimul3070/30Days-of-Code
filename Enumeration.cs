using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NaimulIsam
{
    class Enumeration
    {
        enum Days { sun, mon, tues, wed, thursday, friday };

        static void Main(string[] args)
        {
            Console.Write(Days.sun);
            Console.ReadKey();
        }
    }
}
