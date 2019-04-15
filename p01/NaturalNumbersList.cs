using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01
{

    /// <summary>
    /// A list of natural numbers
    /// </summary>
    /// 
    public class NaturalNumbersList
    {
        private readonly long _max;
        private readonly long[] _multiples;

        /// <summary>
        /// The list of natural numbers below max that are a multiple of one of numbers in multiples
        /// </summary>
        /// <param name="max">Max value of our list of natural numbers</param>
        /// <param name="multiples">Array of numbers that our natural number list must be a multiple of</param>
        public NaturalNumbersList(long max, params long[] multiples)
        {
            if (max < 0)
                throw new ArgumentException("max must be a positive number", "max");

            if (multiples == null)
                throw new ArgumentException("multiples cannot be null", "multiples");

            if (multiples.LongLength < 1)
                throw new ArgumentException("multiples must contain at least one value", "multiples");

            foreach (long m in multiples)
            {
                if (m > max)
                    throw new ArgumentException("multiples cannot contain a number > max", "multiples");
            }

            _max = max;
            _multiples = multiples;
        }

        private long? _sumOfMultiples = null;


        /// <summary>
        /// The sum of our list of natural numbers, i.e. the sum of natural numbers that are a multiple of
        /// one of our _multiples less than _max
        /// </summary>
        /// <returns></returns>
        public long SumOfMultiples
        {
            get
            {
                if (_sumOfMultiples == null)
                {
                    long sum = 0;

                    for (long i = 0; i <= _max; i++)
                    {
                        foreach (long m in _multiples)
                        {
                            if (i % m == 0)
                            {
                                sum += i;
                                break;
                            }
                        }
                    }

                    _sumOfMultiples = sum;
                }

                return _sumOfMultiples.Value;
            }
        }
    }
}
