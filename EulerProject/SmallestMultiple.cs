using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class SmallestMultiple
    {
        public static int Answer()
        {
            
            for (long i = 1; i < 10000000000; i++)
            {
                int j = 20;
               while(i%j==0) {
                   j--;
                    if (j == 1)
                    {
                        Console.Write("I Is: "+i+" ");
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
