using System;

namespace Reversing_InegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type Your Number");
            int number = Convert.ToInt32(Console.ReadLine()); ;
            int reverseNumber = 0;
            while (number!=0)
            { 
                int lastDigit = Convert.ToInt32(number % 10);
                number = Convert.ToInt32(number / 10);
                reverseNumber = reverseNumber * 10 + lastDigit;
            }
            Console.WriteLine("Reverse Number is " + reverseNumber);





        }
    }
}
