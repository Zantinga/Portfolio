// See https://aka.ms/new-console-template for more information
using LeetCode;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        // 1. Two Sum
        TwoSum();
    }

    private static void TwoSum()
    {
        var TwoSum = new TwoSum();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        // Output: [0, 1]
        Console.WriteLine("[{0}]", string.Join(",", TwoSum.Solution(nums, target)));
    }
}