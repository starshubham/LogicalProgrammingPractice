using System;

/*
Reverse a number
In C#, we can reverse a number either by using for loop, while loop, or using recursion.
The simplest way to reverse a number is by using for loop or while loop. In order to
reverse a number, we have to follow the following steps:
a. We need to calculate the remainder of the number using the modulo
b. After that, we need to multiply the variable reverse by 10 and add the remainder into
it.
c. We then divide the number by 10 and repeat steps until the number becomes 0.
 */

namespace Reverse_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;

            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            Console.WriteLine($"The Reverse order is : {reverse}");
            Console.ReadKey();
        }
    }
}
