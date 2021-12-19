using System;

/*
Fibonacci Series
Fibonacci series is a special type of series in which the next term is the sum of the
previous two terms. For example, if 0 and 1 are the two previous terms in a series, then
the next term will be 1(0+1).
 */

namespace FibonacciSeries
{
    class Program
    {
        // Function to find n terms
        // of series
        static void findSeries(int num,
                    int first, int sec)
        {

            Console.Write(first + " "
                        + sec + " ");
            int counter = 0, sum;

            // find next (num - 2) terms
            // of series as first two
            // terms are already given
            while (counter < num - 2)
            {
                sum = first + sec;
                Console.Write(sum + " ");
                first = sec;
                sec = sum;
                counter++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the nth term you want the series: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0, sec = 1;

            findSeries(n, first, sec);
        }
    }
}
