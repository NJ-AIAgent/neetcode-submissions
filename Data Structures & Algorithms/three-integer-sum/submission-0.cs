public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        var set = new HashSet<string>();
        var result = new List<List<int>>();
        for(int i = 0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                for(int k=j+1;k<nums.Length;k++){
                    if(nums[i]+nums[j]+nums[k] == 0){
                        var triplet = new List<int>{nums[i],nums[j],nums[k]};
                        triplet.Sort();

                        string key = $"{triplet[0]},{triplet[1]},{triplet[2]}";

                        if(set.Add(key)){
                            result.Add(triplet);
                        }

                    }
                       
                }

            }
        }
    return result;
    }
}
