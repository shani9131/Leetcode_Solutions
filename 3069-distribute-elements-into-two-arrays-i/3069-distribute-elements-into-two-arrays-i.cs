public class Solution {
    public int[] ResultArray(int[] nums) {
        List<int> l1 = new List<int>();
        List<int> l2 = new List<int>();
        
        l1.Add(nums[0]);
        l2.Add(nums[1]);
        
        for(int i = 2; i < nums.Length; i++) {
            if(l1[l1.Count - 1] > l2[l2.Count - 1]) {
                l1.Add(nums[i]);
            } else {
                l2.Add(nums[i]);
            }
        }
        l1.AddRange(l2);
        
        return l1.ToArray();
    }
}