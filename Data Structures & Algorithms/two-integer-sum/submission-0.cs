public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            int complement = target - nums[i];
            if(dict.TryGetValue(complement, out int index)){
                return new int[]{index,i};
            }
            dict[nums[i]] = i;
        }
        return new int[]{};
    }
}
