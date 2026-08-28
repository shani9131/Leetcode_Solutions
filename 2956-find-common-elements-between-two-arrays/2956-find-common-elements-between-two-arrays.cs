public class Solution
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        =>
        [GetIndexCounter(nums1, nums2), GetIndexCounter(nums2, nums1)];

    static int GetIndexCounter(int[] targetArrays , int[] nums)
    {
        var counter = 0;
        foreach (var item in targetArrays)
            if(GetIndexChecking(nums , item))
                counter++;
        return counter;
    }
    
    static bool GetIndexChecking(int[] nums, int target)
        => nums.Contains(target) ? true : false;
}