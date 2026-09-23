class Solution {
    public int minOperations(int[] nums, int x) {
        int n = nums.length;
        int total = 0;
        for (int num : nums) total += num;

        int target = total - x;
        if (target < 0) return -1; 

        int maxLen = -1;
        int left = 0, currSum = 0;

        for (int right = 0; right < n; right++) {
            currSum += nums[right];

            while (left <= right && currSum > target) {
                currSum -= nums[left++];
            }

            if (currSum == target) {
                maxLen = Math.max(maxLen, right - left + 1);
            }
        }

        return maxLen == -1 ? -1 : n - maxLen;
    }
}