using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class EvenFibonacciNumbers
    {
        public static int Answer()
        {
            int fib1 = 1;
            int fib2 = 2;
            int fibnext = 0;
            int Answer2 = 0;
            while (fibnext < 4000000)
            {
                fibnext = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibnext;
               

                if (fibnext % 2 == 0)
                {
                    Answer2 += fibnext;
                }
            }
            return Answer2+2;
        }
    }
}
