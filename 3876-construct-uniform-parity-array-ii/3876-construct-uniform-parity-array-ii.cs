public class Solution {
    public bool UniformArray(int[] nums1) {
        bool hasOdd = false;
        int minNumber = int.MaxValue;

        foreach(var num in nums1){
            if(num % 2 != 0)
                hasOdd = true;
            minNumber = Math.Min(minNumber, num);
        }
        
        return (minNumber % 2 != 0) || !hasOdd;
    }
}