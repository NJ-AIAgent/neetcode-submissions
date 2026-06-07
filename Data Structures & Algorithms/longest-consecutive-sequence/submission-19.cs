public class Solution {
    public int LongestConsecutive(int[] nums) {
       var set = new HashSet<int>(nums);
        int count = 0;
       foreach(var num in set){
        if(!set.Contains(num-1)){
            int currentnum = num;
            int currentStreak = 1;

            while(set.Contains(currentnum + 1)){
                currentnum += 1;
                currentStreak += 1; 
            }
            count = Math.Max(currentStreak,count);
        }
       }
       return count;
}
}
