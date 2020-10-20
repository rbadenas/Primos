using System;

namespace primeNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            var eratosthenesSieve = new EratosthenesSieve();

            Console.WriteLine("Acumulated sum of 50 first prime numbers is " + eratosthenesSieve.sumOf50firstPrimes());
            Console.WriteLine("Acumulated sum of primes in the 50 first numbers is " + eratosthenesSieve.sumOfPrimesIn50firstNumbers() );
        }

    }
}
