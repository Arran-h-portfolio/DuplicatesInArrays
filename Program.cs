using System.Globalization;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
           if (i == 0 || nums[i] != nums[i - 1])
            {
                nums[k++] = nums[i];
            } 
        }
        return k;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[][] testCases = new int[][]
        {
            new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 },
            new int[] { 1, 1, 1, 1 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 1, 1, 2 },
            new int[] { },
            new int[] { 5 }
        };

        for (int i = 0; i < testCases.Length; i++)
        {
            int[] nums = testCases[i];

            int k = solution.RemoveDuplicates(nums);

            Console.Write($"Test {i}: k = {k}, values = ");

            for (int j = 0; j < k; j++)
            {
                Console.Write(nums[j] + " ");
            }

            Console.WriteLine();
        }
    }
}
