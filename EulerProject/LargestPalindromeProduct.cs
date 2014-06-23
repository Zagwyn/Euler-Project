using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class LargestPalindromeProduct
    {
        public static int Answer()
        {
            int product;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    product = i * j;

                    int prod1, prod2, prod3, prod4, prod5, prod6;
                   // product = 123456;
                    prod1 = product/100000 % 10;
                    prod2 = product/10000 % 10;
                    prod3 = product/1000 % 10;
                    prod4 = product/100 % 10;
                    prod5 = product/10 % 10;
                    prod6 = product/1 % 10;
                    //Console.Write(product + " " );
                    if (prod1 == prod6) {
                        if (prod2 == prod5)
                        {
                            if (prod3 == prod4)
                            {
                                if (i >= 900)
                                {
                                    if (j >= 900)
                                    {
                                        Console.Write(product + "i: " + i + "j: " + j + " \n");
                                        // Console.Write(prod1 + " " + prod2 + " " + prod3 + " " + prod4 + " " + prod5 + " " + prod6 + " ");
                                    }
                                }
                            }
                        }
                    }


                }
            }


                return 0;
        }
     
    }
}
