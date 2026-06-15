public class Solution {
    public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length-1;
        int min  = int.MaxValue;

        while(low<high){
            int mid = low + (high-low)/2;

            if(nums[mid] > nums[high]){
                low = mid + 1;
            }
            else {
             min =  Math.Min(min, nums[mid]);
             high = mid-1; 
            }

        }

        return Math.Min(min, nums[low]);
        }
        
    }
