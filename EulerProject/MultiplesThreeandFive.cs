using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class MultiplesThreeandFive
    {
        public static int Answer()
        {
            int temp1, temp2, x, Answer1;
            Answer1 = 0;

            for (int i = 0; i < 1000; i++)
            {
                x = i;
                temp1 = x;
                temp2 = x;

                if (temp1 % 3 == 0)
                {
                    Answer1 += x;
                }
                else if (temp2 % 5 == 0)
                {
                    Answer1 += x;

                }
            }
            return Answer1;
        }
    }
}
