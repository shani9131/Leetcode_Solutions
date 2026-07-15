class Solution {
    public boolean canPartition(int[] arr, long maxSum,
                                long maxPartitions) {
        long partitions = 1;
        long curSum = 0;

        for (int a : arr) {
            if (a > maxSum) {
                return false;
            }

            if (a + curSum <= maxSum) {
                curSum += a;
            } else {
                partitions++;
                curSum = a;

                if (partitions > maxPartitions) {
                    return false;
                }
            }
        }

        return partitions <= maxPartitions;
    }

    public int splitArray(int[] nums, int k) {
        long totalSum = 0;
        long maxEl = 0;

        for (int num : nums) {
            maxEl = Math.max(maxEl, num);
            totalSum += num;
        }

        // long l = maxEl, r = totalSum;
        long l = maxEl - 1;
        long r = totalSum;

        // while (l <= r) {
        while (l + 1 < r) {
            long mid = l + (r - l) / 2;

            // Try smaller sum
            if (canPartition(nums, mid, k)) {
                // r = mid - 1;
                r = mid;
            }
            // Try larger sum
            else {
                // l = mid + 1;
                l = mid;
            }
        }

        // return (int) l;
        return (int) r;
    }
}