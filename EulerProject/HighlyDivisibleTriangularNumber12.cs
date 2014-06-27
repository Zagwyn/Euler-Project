using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class HighlyDivisibleTriangularNumber12
    {
        public static int Answer(){
            int trianglenumber = 0;
            int count =0;
            for (int i = 0; i < 1000000; i++)
            {
                Console.Write("I: " + i + "\n");
                trianglenumber += i;
                count = 0;
                for (int j = trianglenumber; j > 0; j--)
                {
                    if (trianglenumber % j == 0)
                    {
                        count++;
                    }
                    if (count == 500)
                    {
                        Console.Write(trianglenumber + "\n");
                    }
                }
                

            }


                return 0;
        }
    }
}
//Answer: 103672800