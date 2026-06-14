public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int lo = 1, hi = piles.Max(); // if array is 1 indexed array
        int ans = piles.Max();

        while (lo <= hi) {
            int mid = lo + (hi - lo) / 2;

            long hours = 0;
            foreach (int p in piles)
                hours += (p + mid - 1) / mid;  

            if (hours <= h){
                ans = mid;
                hi = mid-1;   
            }
                   
            else
                lo = mid + 1;  
        }

        return ans;   
    }
}