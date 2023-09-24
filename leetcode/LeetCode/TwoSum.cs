/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
*/
using System.Runtime.CompilerServices;

namespace LeetCode
{
    public class TwoSum
    {
        //This runs in O = n^2. No good!
        public int[] Solution(int[] nums, int target)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 0; y < nums.Length; y++)
                {
                    if (x != y && nums[x] + nums[y] == target)
                    {
                        return new int[] { x, y };
                    }
                }
            }
            return new int[] { };
        }

        //This should run in O = nLog(n)
        public int[] Solution2(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int x = 0; x < nums.Length; x++)
            {
                var comp = target - nums[x];
                if (dict.ContainsKey(comp)) 
                {
                    return new int[] { dict[comp], x };
                }

                dict.Add(nums[x], x);
            }

            return new int[] { };
        }

       public void execute()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Two Sum");
            var TwoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            // Output: [0, 1]
            Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution(nums, target)));
            Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution2(nums, target)));

            nums = new int[] { 3, 2, 4 };
            target = 6;
            // Output: [1, 2]
            Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution(nums, target)));
            Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution2(nums, target)));

            nums = new int[] { 3, 3 };
            target = 6;
            // Output: [0, 1]
            Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution(nums, target)));
            Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution2(nums, target)));
        }
    }
}
