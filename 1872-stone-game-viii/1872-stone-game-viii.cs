public class Solution {
    public int StoneGameVIII(int[] stones) {
        int totalSum = 0;
        foreach (var stone in stones) {
            totalSum += stone;
        }

        int maxDifference = totalSum;

        for (int i = stones.Length - 1; i >= 2; i--) {
            totalSum -= stones[i];
            
            maxDifference = Math.Max(maxDifference, totalSum - maxDifference);
        }

        return maxDifference;
    }
}