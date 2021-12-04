using System;
using System.Linq;

namespace DailyCode
{
    public static class Mathematical
    {
        /// Given n numbers, finds the greatest common denominator between them.
        /// For example, given the numbers [42, 56, 14], returns 14.
        /// GCD will be at least 1 for any number set.
        public static int Gcd(int[] numbers)
        {

            return Util.RangeIterator(2, numbers.Max())
                .Select(n =>
                {
                    bool dividesAll = numbers.All(i => IsDivisor(i, n));
                    return (n, dividesAll);
                })
                .Select(pair => pair.dividesAll ? pair.n : 1)
                .Max();
        }

        private static bool IsDivisor(int num, int denom) => num % denom == 0;
    }
}