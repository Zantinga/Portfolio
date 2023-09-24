using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                int max = 0, left = 0, right = 0;
                var charSet = new HashSet<char>();

                while (right < s.Length)
                {
                    if (!charSet.Contains(s[right]))
                    {
                        charSet.Add(s[right]);
                        max = charSet.Count() > max ? charSet.Count() : max;
                        right++;
                    }
                    else
                    {
                        charSet.Remove(s[left]);
                        left++;
                    }
                }

                return max;
            }
        }

        public void execute()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("3. Longest Substring Without Repeating Characters");

            Solution solution = new Solution();
            // Output: 3
            Console.WriteLine(solution.LengthOfLongestSubstring("abcabcbb"));
            // Output: 1
            Console.WriteLine(solution.LengthOfLongestSubstring("bbbbb"));
            // Output: 3
            Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew"));
        }
    }
}
