public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numMap = new Dictionary<int, int>(); // A mapping to store numbers and their indices
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i]; // Find the required number to reach the target
            if (numMap.ContainsKey(complement)) {
                return new int[] { numMap[complement], i }; // Return indices of the complement and current number
            }
            numMap[nums[i]] = i; 
        }
        return new int[] {}; 
    }
}