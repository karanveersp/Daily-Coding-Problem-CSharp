using System.Collections.Generic;
using System;

namespace DailyCode
{
    public static class Util
    {
        /// Implementation of Python's Range function.
        public static IEnumerable<int> RangeIterator(int start, int stop, int step = 1)
        {
            if (step == 0)
                throw new ArgumentException("Parameter step cannot equal zero.");

            int x = start;

            do
            {
                yield return x;
                x += step;
                bool beyondBackwardsLimit = step < 0 && x <= stop;
                bool beyondForwardsLimit = step > 0 && x >= stop;
                if (beyondBackwardsLimit || beyondForwardsLimit)
                    break;
            }
            while (true);
        }

        /// Enumerator from [0, stop) with single step.
        public static IEnumerable<int> Range(int stop) => RangeIterator(0, stop);
    }
}