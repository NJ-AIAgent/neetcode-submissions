public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

    var set = new HashSet<string>();
    var result = new List<List<int>>();

    Array.Sort(nums);
    for(int t = 0;t<nums.Length;t++){
        int target = 0 - (nums[t]);


        int i = t+1;
        int j = nums.Length-1;

        while(i<j){
            if(nums[i] + nums[j] > target){
                j--;
            }
            else if(nums[i] + nums[j] < target)
             i++;
            else{
                var triplet = new List<int>{nums[i],nums[j],nums[t]};
                triplet.Sort();

                var key = $"{triplet[0]},{triplet[1]},{triplet[2]}";
                if(set.Add(key)){
                    result.Add(triplet);
                }
                i++;
                j--;
            } 
                 
        } 
        
    }
        
    return result;
    }
}
