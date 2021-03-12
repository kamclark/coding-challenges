using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Solution
    {
        // Given nums = [11, 7, 2, 15], target = 9
        // return [0, 1].

        // Given nums = [5, 5, 11, 8] target = 19
        // return [2, 3].

        public static int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                if (!map.ContainsKey(nums[i])) map.Add(nums[i], i);
            }
            throw new Exception("No two sum solution.");
        }

        static void Main(string[] args)
        {
            int[] junk = { 11, 7, 2, 15 };
            int[] junk2 = { 5, 5, 11, 8 };

            TwoSum(junk, 9);

            do
            {
                while (!Console.KeyAvailable)
                {   
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}