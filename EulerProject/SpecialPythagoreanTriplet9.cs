using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 

A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a2 + b2 = c2

For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

 * 
 * */
namespace EulerProject
{
    class SpecialPythagoreanTriplet9
    {
        public static int Answer()
        {

            int a, b, c, a2, b2, c2 = 0;
            for (a = 0; a < 1000; a++)
            {
                for (b = 0; b < 1000; b++)
                {
                    for (c = 0; c < 1000; c++)
                    {
                        a2 = a * a;
                        b2 = b * b;
                        c2 = c * c;
                        if ((a2 +  b2) == c2)
                        {                            
                            if (a + b + c == 1000)
                            {
                                if (a < b) {
                                    if (b < c) { 
                                    Console.Write("\n a= " + a + "\n b= " + b + "\n c= " + c);
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
            Console.Write("\n");
            return 0;
        }
    }

}
