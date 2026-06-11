public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] n = new int[nums.Length - k + 1];
        int start = 0;
        int end = start + k-1;
        while(end < nums.Length){
            int max = int.MinValue;
            for(int i = start; i <= end; i++){
                if(nums[i] > max){
                    max = nums[i];
                }
            }
            n[start] = max;
            start++;
            end++;
        }
        return n;
    }

}
