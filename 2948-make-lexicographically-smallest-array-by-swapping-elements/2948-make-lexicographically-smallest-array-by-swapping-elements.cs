public class Solution {
    public int[] LexicographicallySmallestArray(int[] nums, int limit) {
        int[] numsSorted = (int[])nums.Clone();
        Array.Sort(numsSorted);

        int currGroup = 0;
        Dictionary<int, int> numToGroup = new Dictionary<int, int>();
        Dictionary<int, Queue<int>> groupToList = new Dictionary<int, Queue<int>>();

        numToGroup[numsSorted[0]] = currGroup;
        groupToList[currGroup] = new Queue<int>();
        groupToList[currGroup].Enqueue(numsSorted[0]);

        for (int i = 1; i < numsSorted.Length; i++) {
            if (numsSorted[i] - numsSorted[i - 1] > limit) {
                currGroup++;
                groupToList[currGroup] = new Queue<int>();
            }
            numToGroup[numsSorted[i]] = currGroup;
            groupToList[currGroup].Enqueue(numsSorted[i]);
        }

        for (int i = 0; i < nums.Length; i++) {
            int group = numToGroup[nums[i]];
            nums[i] = groupToList[group].Dequeue();
        }

        return nums;
    }
}