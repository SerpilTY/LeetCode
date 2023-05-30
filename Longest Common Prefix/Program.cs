public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs[0] == "") return "";
        string prefix = "";
        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));
        int count = 0;
        for (var i = 0; i < strs[0].Length; i++)
        {
            char mychar = strs[0][i];
            foreach (var item in strs)
            {
                if (mychar == item[i])
                {
                    count++;
                    if (count == strs.Length)
                    {
                        count = 0;
                        prefix += mychar;
                    }
                }
                else { count = -1; break; }
            }
            if (count == -1)
                break;
        }

        return prefix;
    }
}
class Result
{
    public static void Main(string[] args)
    {
        Solution soly = new Solution();
        string[] stry = { "flower", "flawer", "flvwer", "flower" };
        Console.WriteLine(soly.LongestCommonPrefix(stry));

    }

}
