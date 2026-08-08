class Solution {
    Boolean dp[];

    public boolean solve(int[] nums, int n, int idx){
        if(idx>=n-1){
            return true;
        }
        if(dp[idx]!=null){
            return dp[idx];
        }

        for(int i=1;i<=nums[idx];i++){
            if(solve(nums,n,idx+i)==true) return dp[idx]=true;
        }
        return dp[idx]=false;

    }
    public boolean canJump(int[] nums) {
        int n=nums.length;
        dp=new Boolean[n];
        
        return solve(nums,n,0);
       
    }
}