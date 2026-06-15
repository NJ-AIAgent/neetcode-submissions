public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;
        for(int i = 0;i<nums.Length;i++){
            min = Math.Min(nums[i],min);
        }
        return min;
        
    }
}
