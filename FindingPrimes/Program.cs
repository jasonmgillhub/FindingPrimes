using System;
using System.Timers;

namespace FindingPrimes
{
    public class Program
    {
        static private int largestPrime = 0;
        static private int seconds = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Finding Primes!");

            // Kicks off timer that will print my largest prime.
            Timer timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(HandleInterval);
            timer.Interval = 1000; // 1000 ms is one second
            timer.Start();
            

            // Starts at 2 and counts up until 60 seconds has passed.
            var num = 2;
            do
            {
                if (IsPrimeNumber(num)) { 
                    largestPrime = num;
                }

                num++;
            } while (seconds < 60);
        }

        public static bool IsPrimeNumber(int number)
        {
            bool CalculatePrimeNumber(int num)
            {
                // Trial division checks whether num is a multiple of any integer between 2 and sqrt(num)
                var factors = Math.Sqrt(num);

                for (var factor = 2; factor <= factors; factor++)
                    if (num % factor == 0)
                        return false;

                return true;
            }

            // Ignore any number 1 or less
            return number > 1 && CalculatePrimeNumber(number);
        }

        static void HandleInterval(object source, ElapsedEventArgs e)
        {
            // Print the largest prime calculated so far
            Console.WriteLine(largestPrime);
            // Increment the number of seconds
            seconds++;
        }
    }
}
