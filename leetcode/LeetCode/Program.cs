// See https://aka.ms/new-console-template for more information
using LeetCode;

Console.WriteLine("Hello, World!");

// 1. Two Sum
TwoSum();

void TwoSum()
{
    var TwoSum = new TwoSum();
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;
    // Output: [0, 1]
    Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution(nums, target)));
}
