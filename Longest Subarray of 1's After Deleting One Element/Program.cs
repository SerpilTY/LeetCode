using System.ComponentModel;

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        string a = string.Join("", nums);
        if (!a.Contains("0"))
            return a.Length - 1;
        else
        {
            string[] arr = a.Split('0');
            List<int> lengths = new List<int>();
            List<int> result = new List<int>();
            for (var i = 0; i < arr.Length; i++)
            {
                lengths.Add(arr[i].Length);
            }

            for (var i = 0; i < lengths.Count - 1; i++)
            {
                result.Add(lengths[i] + lengths[i + 1]);
            }
            return result.Max();
        }
    }
    public static void Main(string[] args)
    {
        Solution soly = new Solution();
        int[] nums = new int[] { 1, 1, 1 };
        System.Console.WriteLine(soly.LongestSubarray(nums));
    }
}