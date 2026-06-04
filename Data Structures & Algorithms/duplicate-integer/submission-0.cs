public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            if(dict.TryGetValue(nums[i],out int index)){
                return true;
            }
            dict[nums[i]] = i;
        }
        return false;
    }
}