using System;

/*
Perfect Number
a. Just like the Armstrong number, the Perfect Number is also a special type of
positive number. When the number is equal to the sum of its positive divisors
excluding the number, it is called a Perfect Number. For example, 28 is the perfect
number because when we sum the divisors of 28, it will result in the same number.
The divisors of 28 are 1, 2, 4, 7, and 14. So,
b. 28 = 1+2+4+7+14
*/

namespace PerfectNumber
{
    class Program
    {
        // Returns true if n is perfect
        static bool isPerfect(int n)
        {
            // To store sum of divisors
            int sum = 1;

            // Find all divisors and add them
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                        sum = sum + i + n / i;
                    else
                        sum = sum + i;
                }
            }
            // If sum of divisors is equal to
            // n, then n is a perfect number
            if (sum == n && n != 1)
                return true;

            return false;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Below are all perfect" +
                                "numbers till 10000");
            for (int n = 2; n < 10000; n++)
            {
                if (isPerfect(n))
                    System.Console.WriteLine(n + " is a perfect number");
            }                
        }
    }
}
