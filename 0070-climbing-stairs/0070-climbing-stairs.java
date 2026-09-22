class Solution {
    Integer dp[];
    public int solve(int n){
        if(n<0){
            return 0;
        }
        if(n==0){
            return 1;
        }
        if(dp[n]!=null){
            return dp[n];
        }
        int firststep=solve(n-1);
        int secstep=solve(n-2);

        return dp[n]= firststep+secstep;

    }


    public int climbStairs(int n) {
        dp=new Integer[n+1];

        return solve(n);
    }
}