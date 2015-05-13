using System;
using System.Collections.Generic;

namespace FizzBuzzCSharp.FizzBuzz
{
    public class FizzBuzz
    {
        readonly static int THREE = 3;
        readonly static int FIVE = 5;

        public static void Run()
        {
            for(var i=1; i <= 100; i++)
            {
                Console.WriteLine(Calculate(i));   
            }            
        }

        public static string Calculate(int number)
        {
            var divisibleByThree = (number % THREE == 0);
            var divisibleByFive = (number % FIVE == 0);
            if (divisibleByThree && divisibleByFive)
            {
                return "FizzBuzz";
            }
            else if (divisibleByThree)
            {
                return "Fizz";
            }
            else if (divisibleByFive)
            {
                return "Buzz";
            }            
            return number.ToString();
            
        }
    }
}