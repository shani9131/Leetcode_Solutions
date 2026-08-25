public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        HashSet<int> numbers = new HashSet<int>(nums);            

        for (int i = 1; ; i++) {                                  
            int multiple = k * i;                                    
            if (!numbers.Contains(multiple))                
                return multiple;                                    
        }
    }
}