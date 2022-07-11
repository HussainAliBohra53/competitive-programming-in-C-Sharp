**LCS Problem Statement:** Given two sequences, find the length of longest subsequence present in both of them. A subsequence is a sequence that appears in the same relative order, but not necessarily contiguous. For example, “abc”, “abg”, “bdf”, “aeg”, ‘”acefg”, .. etc are subsequences of “abcdefg”. 
**Examples:**
LCS for input Sequences “ABCDEF” and “BADCEF” is “ACEF” or "BCEF" of length 4. 
LCS for input Sequences “AGGTAB” and “GXTXAYB” is “GTAB” of length 4.

**Brute Force Approach**
Brute force appraoch is generate all subsequences of both the strings and search for the longest common subsequence. 
for example: Given two Strings ABC and AGC
find the all subsequences of both the strings.
ABC-> {}{A}{B}{C}{AB}{AC}{BC}{ABC}
AGC-> {}{A}{G}{C}{AG}{AC}{GC}{AGC}
Here the longest matching subsequence is {AC} so answer is 2 or {AC} based on question.

**Optimal Solution**

Brute Force approach gives you the solution with the exponential time complexity. Let's discuss optimal solution
Let we have two Strings X[0,,,,m-1] and Y[0,,,,n-1] of length m and n.
And let LCS(X[0..m-1], Y[0..n-1]) be the length of LCS of the two sequences X and Y.

### If last characters of both sequences match (or X[m-1] == Y[n-1]) then
LCS(X[0..m-1], Y[0..n-1]) = 1 + LCS(X[0..m-2], Y[0..n-2])

### If last characters of both sequences do not match (or X[m-1] != Y[n-1]) then
LCS(X[0..m-1], Y[0..n-1]) = MAX ( LCS(X[0..m-2], Y[0..n-1]), LCS(X[0..m-1], Y[0..n-2]) )

here is the recursive solution for the problem

```
int LCS( char[] X, char[] Y, int m, int n )
{
    if (m == 0 || n == 0)
    return 0;
    if (X[m-1] == Y[n-1])
    return 1 + lcs(X, Y, m-1, n-1);
    else
    return Math.MAX(LCS(X, Y, m, n-1), LCS(X, Y, m-1, n));
}
```
Time complexity of the above naive recursive approach is O(2^n) in worst case and worst case happens when all characters of X and Y mismatch i.e., length of LCS is 0. 

***Dynamic Programming***
 Following is a Memoization implementation for the LCS problem. 
 ```
 static int CalculateLCS(String X, String Y, int m, int n, int[,] dp)
        {
            if (m == 0 || n == 0)   //checking if reached end of the string
                return 0;

            if (dp[m, n] != -1)
                return dp[m, n];

            if (X[m - 1] == Y[n - 1])
            {
                ans += X[m - 1];
                dp[m,n] = 1 + CalculateLCS(X, Y, m - 1, n - 1, dp);
                return dp[m,n];
            }

            dp[m,n] = Math.Max(CalculateLCS(X, Y, m, n - 1, dp), CalculateLCS(X, Y, m - 1, n, dp));
            return dp[m,n];
        }
```
Using the Memoization, we store the solution of subproblems every time we solve and if encountered the same problem again we use stored solution. The above solution gives time complexity of O(n,m).
