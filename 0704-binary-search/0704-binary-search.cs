public class Solution {
    public int Search(int[] nums, int target) {
        int n=nums.Length;
        // int left=0;
        // int right=nums.Length-1;

        // while(left<=right){
        //     int mid=left+(right-left)/2;

        //     if(nums[mid]==target){
        //         return mid;
        //     }else if(target>nums[mid]){
        //         left=mid+1;
        //     }else if(target<nums[mid]){
        //         right=mid-1;
        //     }
        // }
        // return -1;
        return binarysearch(0,n-1,nums, target);
        
    }

    public int binarysearch(int left, int right, int[] nums, int target){
        if(left>right) return -1;

        

            int mid=left+(right-left)/2;

            if(nums[mid]==target){
                return mid;

            }else if(target>nums[mid]){
                return binarysearch(mid+1,right,nums,target);
            }else{
                return binarysearch(left,mid-1,nums,target);
            }

        
        
    }
}