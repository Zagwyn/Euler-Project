using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject
{
    class SumSquareDifference
    {
        public static long Answer()
        {
            long sumofsquare = 0;
            long squareofsum = 0;
            for (long i = 1; i <= 100; i++)
            {
                long temp = i * i;
                sumofsquare += temp;

                squareofsum += i;


            }
            squareofsum = squareofsum * squareofsum;
            long answer = squareofsum - sumofsquare;
                return answer;
        }
    }
}
