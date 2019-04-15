using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    /*
        A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        a^2 + b^2 = c^2

        For example, 32 + 42 = 9 + 16 = 25 = 52.

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.

        Answer:
        Eliminate c - so a^2 + b^2 == (1000 - a - b)^2

        a = 200
        b = 375
        therefore, c = 425

        and a*b*c = 31875000
    */
    public static class p9
    {

        public  static void SolveForAandB()
        {

            for (int a = 1; a <= 1000; a++)
            {
                for (int b = a; b <= 1000; b++)
                {
                    if (((a*a) + (b*b)) == ((1000 - a - b) * (1000 - a - b)) )
                    {
                        int _a = a;
                        int _b = b;
                        break;
                    }
                }
            }

        }

    }
}
