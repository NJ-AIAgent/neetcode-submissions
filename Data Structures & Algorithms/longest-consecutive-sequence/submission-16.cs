public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        Array.Sort(nums);
        int count = 1;
        int max = 1;
        for(int i = 0;i<nums.Length-1;i++){
            if(nums[i+1] == nums[i]){
                continue;
                }
            else if(nums[i+1] == nums[i]+1){
                count++;
                max = Math.Max(max, count);
            }
            else {
                count = 1;
                continue;
            }
            
        }
    return max;
    }
}
