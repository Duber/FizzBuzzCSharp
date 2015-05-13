using System;
using System.Collections.Generic;

namespace FizzBuzzCSharp.FizzBuzz
{
    public class FizzBuzz
    {
        public static void Run()
        {
            for(var i=1; i <= 100; i++)
            {
                var divisibleByThree = (i % 3 == 0);
                var divisibleByFive = (i % 5 == 0);
                if (divisibleByThree && divisibleByFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (divisibleByThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divisibleByFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }                
            }            
        }
    }
}