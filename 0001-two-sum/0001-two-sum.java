class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> mp=new HashMap();

        for(int i=0;i<nums.length;i++){
            mp.put(nums[i], i);
        } 

        for(int i=0;i<nums.length;i++){
            int c=target - nums[i];
            if(mp.containsKey(c)){
                int index=mp.get(c);
                if(index==i) continue;
                return new int[] {i, index};
            }
        }
        
        return new int[] {-1, -1};

    }
}