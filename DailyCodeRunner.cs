using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCode
{
    public static class Runner
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(ContainsPairAddingToTarget(new List<int>{10, 15, 3, 7}, 17));

            // ProductArrayExcludingI(new List<int>{1,2,3,4,5}).ForEach(i => Console.Write($"{i} "));
            // Console.WriteLine();
        }

        public static List<int> ProductArrayExcludingI(List<int> arr) {
            var result = new List<int>();
            for (int i = 0; i < arr.Count; i++) {
                int prod = 1;
                for (int j = 0; j < arr.Count; j++) {
                    if (j == i) {
                        continue;
                    }
                    prod *= arr[j];
                }
                result.Add(prod);
            }
            return result;
        }

        public static bool ContainsPairAddingToTarget(List<int> nums, int target)
        {
            // Approach 1 - Adding item at i with all items i+1 to n.

            // for (int i = 0; i < nums.Count - 1; i++) {
            //     for (int j = i + 1; j < nums.Count; j++) {
            //         int sum = nums[i] + nums[j];
            //         if (sum == target) {
            //             return true;
            //         }
            //     }
            // }
            // return false;

            // Approach 2 - Single pass through nums.
        
            var ints = new List<int>();
        
            foreach (int i in nums) {
                var found = ints.Where(j => i + j == target).Any();
                if (found) {
                    return true;
                }
                ints.Add(i);
            }
            return false;
        }
    }
}
