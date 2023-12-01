namespace EulerMSTest
{
    /// <summary>
    /// Euler Problem 9 - https://projecteuler.net/problem=9
    /// 
    /// A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,
    /// a^2 + b^2 = c^2
    /// 
    /// For example, 32 + 42 = 9 + 16 = 25 = 52.
    ///
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    ///
    /// Answer:
    /// Eliminate c - so a^2 + b^2 == (1000 - a - b)^2
    ///
    /// a = 200
    /// b = 375
    /// therefore, c = 425
    ///
    /// and a* b* c = 31875000
    /// </summary>
    [TestClass]
    [TestCategory("Euler")]
    public class EulerProblem9
    {
        [TestMethod]
        public void SolveProblem9()
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

            int abc_product = _a * _b * _c;

            Console.WriteLine($"a = {_a}, b = {_b}, c = {_c}, a*b*c={abc_product}");

            Assert.AreEqual(31875000, abc_product);
        }
    }
}