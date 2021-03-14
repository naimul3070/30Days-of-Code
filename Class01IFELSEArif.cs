using System;
using System.Collections.Generic;
using System.Text;

namespace NaimulIsam
{
    class Class01IFELSEArif
    {
        static void Main(string[] args)
        {
            int Mark;
            //int a;

            Console.WriteLine("Enter Mark");
            Mark = Convert.ToInt32(Console.ReadLine());

            if (Mark > 100)
            {
                Console.WriteLine("Result Not valid");
            }
            else
            {
                //{
                //    if (Mark < 0)
                //    {
                //        Console.WriteLine("Result is also not valid");
                //    }
                //    else
                //    {
                //        if(Mark >= 80)
                //        {
                //            Console.WriteLine("A+");
                //        }
                //        else
                //        {
                //            if(Mark >= 70)
                //            {
                //                Console.WriteLine("A");
                //            }
                //            else
                //            {
                //                if (Mark >= 60)
                //                {
                //                    Console.WriteLine("B+");
                //                }
                //                else
                //                {
                //                    if(Mark >= 50)
                //                    {
                //                        Console.WriteLine("B");
                //                    }
                //                    else
                //                    {
                //                        Console.WriteLine("F+");
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}



            }if (Mark < 0)
            {
                Console.WriteLine("Vua");
            }
            else if (Mark  >= 80)
            {
                Console.WriteLine("A+");
            }
            else if (Mark >= 70)
            {
                Console.WriteLine("A");
            }
            else if (Mark >= 60)
            {
                Console.WriteLine("B+");
            }
            else if (Mark >= 50)
            {
                Console.WriteLine("B");
            }
            else if (Mark >= 40)
            {
                Console.WriteLine("C");
            }
            else if (Mark >= 33)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F+");
            }
            Console.ReadKey();


        }
    }
}
