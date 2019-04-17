using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09
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
    class Program
    {
        static void Main(string[] args)
        {
            int _a = 0;
            int _b = 0;
            int _c = 425;

            // Solve for a and b
            for (int a = 1; a <= 1000; a++)
            {
                for (int b = a; b <= 1000; b++)
                {
                    if (((a * a) + (b * b)) == ((1000 - a - b) * (1000 - a - b)))
                    {
                        _a = a;
                        _b = b;
                        break;
                    }
                }
            }

            Console.WriteLine("a = {0}, b = {0}, c = {2}, a*b*c={3}", _a, _b, _c, _a*_b*_c);
        }
    }
}
