using System.Collections.Generic;
using System.Linq;

namespace DailyCode
{
    public static class Array
    {
        /// Given an array of integers, return a new array such that 
        /// each element at index i of the new array is the product 
        /// of all the numbers in the original array except the one at i.
        /// For example, if our input was [1, 2, 3, 4, 5], 
        /// the expected output would be [120, 60, 40, 30, 24]. 
        /// If our input was [3, 2, 1], the expected output would be [2, 3, 6].
        /// Follow-up: what if you can't use division?
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