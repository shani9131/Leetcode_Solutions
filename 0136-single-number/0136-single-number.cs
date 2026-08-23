public class Solution {
    public int SingleNumber(int[] nums) {
        int n=nums.Length;
        int count=0;

        for(int i=0;i<n;i++ ){

            count^=nums[i];
        }
        return count;
        
    }
}