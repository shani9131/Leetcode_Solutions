class Solution {
    Integer dp[][];

    public int longestPalindromeSubseq(String s) {
        int n = s.length();
        dp = new Integer[n][n];   
        return solve(0, n-1, s);
    }

    public int solve(int i, int j, String s) {
        if (i > j) return 0;
        if (i == j) return 1;

        if (dp[i][j] != null) return dp[i][j];

        if (s.charAt(i) == s.charAt(j)) {
            return dp[i][j] = 2 + solve(i+1, j-1, s);  
        } else {
            return dp[i][j] = Math.max(solve(i+1, j, s), solve(i, j-1, s));
        }
    }
}
