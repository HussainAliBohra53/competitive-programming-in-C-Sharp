using System;
namespace Competitive_programming_in_C_Sharp.DynamicProgramming
{
    public static class LongestCommonSubsequence
    {
        static String ans;
        static int CalculateLCS(String X, String Y, int m, int n, int[,] dp)
        {
            if (m == 0 || n == 0)   //checking if reached end of the string
                return 0;

            if (dp[m, n] != -1)
                return dp[m, n];

            if (X[m - 1] == Y[n - 1])
            {
                ans += X[m - 1];   //storing our Longest Common Subsequence to print
                dp[m,n] = 1 + CalculateLCS(X, Y, m - 1, n - 1, dp);
                return dp[m,n];
            }

            dp[m,n] = Math.Max(CalculateLCS(X, Y, m, n - 1, dp), CalculateLCS(X, Y, m - 1, n, dp));
            return dp[m,n];  //return the length of LCS of given input string 
        }
        public static int LCS(String X,String Y)
        {
            int m = X.Length;
            int n = Y.Length;
            int[,] dp = new int[m+1,n + 1];
            for (int i = 0; i < m + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    dp[i,j] = -1;
                }
            }
          
            int a=CalculateLCS(X, Y, m, n, dp);
            Console.WriteLine(ans);
            return a;
        }
    }
}
