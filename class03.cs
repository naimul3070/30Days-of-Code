//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NaimulIsam
//{
//    class class03
//    {
//        static void Main(String[] args)
//        {
//            string cont = "y";
//            while (cont.ToLower() == "y")
//            {
//                Console.Clear();
//                int a, b;
//                Console.WriteLine("Enter a");

//                try
//                {
//                    a = Convert.ToInt32(Console.ReadLine());
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Defoult Value of a will : 0\n" + ex.Message);
//                    a = 0;
//                }
//                try
//                {
//                    b = Convert.ToInt32(Console.ReadLine());
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Defoult Value of b will : 0\n" + ex.Message);
//                    b = 0;
//                }

//                Console.WriteLine(a + b);


//                Console.WriteLine("Press y to continue, anykety to exit.");
//                cont = Console.ReadLine();
//            }





//            Console.ReadKey();
//        }
//    }
//}

