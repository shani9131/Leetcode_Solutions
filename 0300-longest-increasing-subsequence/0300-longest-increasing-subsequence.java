class Solution {
    int n;
    Integer dp[][];
    
    public int solve(int[] nums, int i, int p){
        if(i>=n){
            return 0;
        }
        if(p!=-1 && dp[i][p]!=null){
            return dp[i][p];
        }
        int take=0;
        if(p==-1 || nums[p]<nums[i]){
            take=1+solve(nums,i+1,i);
        }
        int skip=solve(nums,i+1,p);
        if(p!=-1){
            dp[i][p]=Math.max(take, skip);
        }
        return Math.max(take, skip);

    }
    public int lengthOfLIS(int[] nums) {
        n=nums.length;
        dp=new Integer[n+1][n+1];
        
        return solve(nums,0,-1);
        
        
    }
}