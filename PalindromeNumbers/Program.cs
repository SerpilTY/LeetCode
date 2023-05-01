public class Solution
{
    public bool IsPalindrome(int x)
    {
        List<char> mixi = x.ToString().ToCharArray().ToList();
        var myStack = new Stack<char>(mixi);
        var que = new Queue<char>(mixi);
        bool result = false;

        if (x < 0) return false;
        if (mixi.Count == 1) return true;

        for (var i = 0; i < mixi.Count; i++)
        {
            if (que.Dequeue() == myStack.Pop())
            {
                result = true;
            }
            else
            {
                result = false;
                break;
            }
        }
        return result;
    }


    class Result
    {
        public static void Main(string[] args)
        {
            Solution soly = new Solution();
            int t = 1000021;
            System.Console.WriteLine(soly.IsPalindrome(t));

        }

    }
}
