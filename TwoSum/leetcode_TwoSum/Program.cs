using System;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int i, j;
        for (i = 0; i < nums.Length; i++)
        {
            for (j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j };
                }

            }

        }
        return new int[2] { 0, 0 };
    }
     void Main(string[] args)
    {
        // Pass the array as an argument.
        TwoSum int [2] = new int[2] { 2, 12 };

        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();

       
        
    }
}