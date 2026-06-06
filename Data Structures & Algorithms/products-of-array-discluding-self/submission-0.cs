public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
    
    int n = nums.Length;
    int[] prefix = new int[n];
    int[] suffix = new int[n];
    int[] result = new int[n];

    prefix[0] = 1;
    suffix[n-1] = 1;

    for(int i = 1 ;i< nums.Length;i++){
        prefix[i] = prefix[i-1] * nums[i-1];       
    }

    for(int i = n-1;i>0;i--){
        suffix[i-1] = suffix[i] * nums[i];
    }

    for(int i = 0 ;i <n ;i++){
        result[i] = prefix[i] * suffix[i];
    }
    return result;    
    }
}
