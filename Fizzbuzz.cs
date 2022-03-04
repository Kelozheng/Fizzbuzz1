using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fizzbuzz
{
    class Program
    {
        public static void Main()
        {


            Console.WriteLine("Please enter the start number:");
            int StartNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the finish number:");
            int FinishNumber = Convert.ToInt32(Console.ReadLine());

            int n = FinishNumber;

            if (FinishNumber >= StartNumber) 
            {
                
                for (int i = StartNumber; i <= n; i++)
            {
                    if (i % 3 == 0)
                    {
                        if (i % 5 == 0)
                        {
                            Console.Write("Fizzbuzz" + " ");
                        }
                        else

                            Console.Write("Fizz" + " ");
                    }

                    else if (i % 5 == 0)

                    {
                        Console.Write("Buzz" + " ");
                    }
                    else
                        Console.Write(i + " ");
             }
            }
            else if (FinishNumber < StartNumber)
            {


                for (int i = StartNumber; i > n; i--)
                {
                    if (i % 3 == 0)
                    {
                        if (i % 5 == 0)
                        {
                            Console.Write("Fizzbuzz" + " ");
                        }
                        else

                            Console.Write("Fizz" + " ");
                    }

                    else if (i % 5 == 0)

                    {
                        Console.Write("Buzz" + " ");
                    }
                    else
                        Console.Write(i + " ");
                }

            }




        }
    }
}