public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        
        Dictionary<int, int> d=new Dictionary<int, int>();
        List<int> l=new List<int>();

        for(int i=0;i<nums.Length;i++){
            if(d.ContainsKey(nums[i])){
                d[nums[i]]++;
            }else{
                d[nums[i]]=1;
            }
        }

        foreach( var x in d){
            if(x.Value==2){
                l.Add(x.Key);

            }
        }
        return l;
    }
}