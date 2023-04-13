public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        int[] subs = new int[2];
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    subs[0] = i;
                    subs[1] = j;
                    return subs;
                }
            }
        }
        return subs;
    }
}

class Result
{
    public static void Main(string[] args)
    {
        Solution soly = new Solution();
        int[] nums = { 3, 3};
        int target = 6;
        foreach (var item in soly.TwoSum(nums, target))
        {
            System.Console.WriteLine(item+" ");
        }
        
    }

}