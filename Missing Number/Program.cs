using System;

namespace Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 4, 4, 1, 3 };
            Console.WriteLine(MissingNumber(nums));
        }

        // https://leetcode.com/problems/missing-number/
        static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int sum = (n * (n + 1)) / 2;
            foreach (int no in nums) sum -= no;
            return sum;
        }
    }
}
