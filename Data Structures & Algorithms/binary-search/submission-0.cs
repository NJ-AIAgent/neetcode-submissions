public class Solution {
    public int Search(int[] nums, int target) {
        int high = nums.Length -1;
        int low = 0;
        int mid = -1;
        while(low <= high){
        mid = low +  (high - low)/2;
        if(nums[mid] < target)
        {
            low = mid+1;
            mid = low +  (high - low)/2;
        }
        else if(nums[mid]>target)
        {
           high = mid-1;
            mid = low +  (high - low)/2;
        }
        else 
            return mid;
        }
       return -1;
        
    }
}
