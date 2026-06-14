public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

       int max = piles.Max(); // 4

        for (int k = 1; k <= max; k++) {
            long time = 0;
            for (int j = 0; j < piles.Length; j++) {
                time += (piles[j] + k - 1) / k;
            }
            if (time <= h)
                return k;   // first valid k is the minimum
        }

        return max;
    }
}
