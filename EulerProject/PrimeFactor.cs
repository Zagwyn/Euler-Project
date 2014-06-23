using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class PrimeFactor
    {
        public static long Answer()
        {
            long Answer3 = 0;
            //double numberinput = 999999999;
            long numberinput = 600851475143;
            for (long i = 1; i < numberinput; i++)
            {
                long number = numberinput - i;
                if (numberinput % number == 0)
                {
                    if (IsPrime(number))
                    {
                        Answer3 = number;
                        Console.Write(number+ " ");

                    }

                }

            }

            return Answer3;
     
        
        }
        static bool IsPrime(long num)
        {
            int sqnumb = (int)Math.Sqrt(num);
            for (int j = sqnumb; j >= 2; j--)
            {
                if (num % j == 0)
                {
                    return false;
                }
                //sqnumb = sqnumb - j;
            }
                return true;
           }
    }
}
