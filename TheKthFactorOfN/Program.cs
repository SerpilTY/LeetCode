public class Solution
{
    public int KthFactor(int n, int k) {
        List<int> FactorList=new List<int>();
        for (var i = 1; i <= n; i++)
        {
            if(n%i==0){
                FactorList.Add(i);
            }
        }

        if(k<=FactorList.Count){
            return FactorList[k-1];
        }
        else return -1;

}
        public static void Main(string[] args)
        {
            int n = 6;
            int k=2;
            Solution soly=new Solution();
            System.Console.WriteLine(soly.KthFactor(n,k));

        }

    }

