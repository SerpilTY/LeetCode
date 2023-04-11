public static class Result
{
    public static int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        int counter = 1;
        int result = 0;
        if (nums.Length == 1)
        {
            result = nums[0];
        }
        else
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        counter++;
                        if (counter > nums.Length / 2)
                        {
                            result = nums[i];
                            return result;
                        }
                    }
                    else { counter = 1; }
                }
            }
        }

        return result;
    }
}


class Solution
{
    public static void Main(string[] args)
    {

        int[] nums = { 3, 2, 3 };
        Console.WriteLine(Result.MajorityElement(nums));
    }

}