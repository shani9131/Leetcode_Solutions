public class Solution {
    public int MinimumDeletions(int[] nums) {
        int n = nums.Length;

        if (n == 1) {
            return 1;
        }

        int min = int.MaxValue;
        int max = int.MinValue;

        int minPos = n;
        int maxPos = -1;

        // Find minimum, maximum and their positions
        for (int i = 0; i < n; i++) {

            if (nums[i] < min) {
                min = nums[i];
                minPos = i;
            }

            if (nums[i] > max) {
                max = nums[i];
                maxPos = i;
            }
        }

        // Positions of min and max in sorted order
        int left = Math.Min(minPos, maxPos);
        int right = Math.Max(minPos, maxPos);

        // Option 1: Delete from the left
        int leftDeletes = right + 1;

        // Option 2: Delete from the right
        int rightDeletes = n - left;

        // Option 3: Delete from both sides
        int bothDeleted = (left + 1) + (n - right);

        // Minimum of all three possibilities
        return Math.Min(
            leftDeletes,
            Math.Min(rightDeletes, bothDeleted)
        );
    }
}