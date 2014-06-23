using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class TenThousandOnestPrime
    {
        public static long Answer()
        {
            int counter = 1;
            for (int i=0; i < 100000000; i++ ){

              //  Console.Write("The I " + i + " \n ");

                int sqnumb = (int)Math.Sqrt(i);

              //  Console.Write("The sqnumb "  + sqnumb + " \n ");

                for (int j = sqnumb; j > 2; j--)
                {
                  //  Console.Write("J is: " + j + " While I is: " + i + "\n");
                    if (i /j == 1)
                    {
                        
                        Console.Write("The count: "+counter + " Prime Number:  " + i + " " + "and Divisor is " + j + "\n ");
                        counter++;
                        if (counter >= 6)
                        {
                            return 1;
                        }
                    }
                }

                
            }
                return 0;
        }
    }
}

/**
int num1;

Console.WriteLine("Accept number:");
num1 = Convert.ToInt32(Console.ReadLine());
if(isPrime(num1))
{
  Console.WriteLine("It is prime");
}
else
{
  Console.WriteLine("It is not prime");
}       

public static boolean isPrime(int number)
{
    int boundary = Math.Floor(Math.Sqrt(number));

    if (number == 1) return false;
    if (number == 2) return true;

    for (int i = 2; i <= boundary; ++i)  {
        if (number % i == 0)  return false;
    }

    return true;        
}
**/