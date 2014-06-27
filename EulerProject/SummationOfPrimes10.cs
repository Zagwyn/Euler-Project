using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

   Find the sum of all the primes below two million.
 * 
 **/
namespace EulerProject
{
    class SummationOfPrimes10
    {
        public static int Answer()
        {
            int primesum = 0;
            //Console.WriteLine("--- Primes between 0 and 100 ---");
            for (int i = 0; i < 2000000; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                if (prime)
                {
                    primesum += i;
                  //  Console.Write("Prime: ");
                  //  Console.WriteLine(i);
                }
            }
            //
            // Write prime numbers between 10000 and 10100
            //
         /*   Console.WriteLine("--- Primes between 10000 and 10100 ---");
            for (int i = 10000; i < 10100; i++)
            {
                if (PrimeTool.IsPrime(i))
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(i);

                }
            } **/
            Console.Write("Prime Sum = " + primesum + "\n");
            return 0;
        }
        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {
                // Test whether the parameter is a prime number.
                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                // Note:
                // ... This version was changed to test the square.
                // ... Original version tested against the square root.
                // ... Also we exclude 1 at the end.
                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }
                return candidate != 1;
            }
        }
    }
}
/*
 * namespace EulerProject
{
    class SummationOfPrimes10
    {
        public static int Answer()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write("I: " + i + "\n");
                for (int j = i-1; j >1; j--)
                {
                    Console.Write("J: " + j + "\n");
                        if (i % j != 0)
                        {
                        Console.Write("Prime: " + i + "\n");
                        }                            
                }
            }
                return 0;
        }
    }
}
*/