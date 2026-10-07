class Solution {
    public int maxSubArray(int[] nums) {
        int n = nums.length;
        int maxi = nums[0]; 
        int sum = nums[0];
        for (int i = 1; i < n; i++) {
            if(sum+nums[i]>nums[i]){
                sum+=nums[i];
            }
            else{
                sum=nums[i];
            }
            maxi=Math.max(maxi,sum);
        }  
        return maxi;
    
    }
}
