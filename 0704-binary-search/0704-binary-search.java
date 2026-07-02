class Solution {
    public int search(int[] nums, int target) {
        int n=nums.length;
        return bnsearch(0,n-1,nums,target);

    }

    public int bnsearch(int left, int right,int[] nums,int target){
        if(left>right){
            return -1;
        }
        int mid=left+(right-left)/2;

        if(nums[mid]==target){
            return mid;
        }else if(target>nums[mid]){
            return bnsearch(mid+1,right,nums,target);
        }else {
            return bnsearch(left,mid-1,nums,target);
        }
        
    }
}