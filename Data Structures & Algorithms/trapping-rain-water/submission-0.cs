public class Solution {
    public int Trap(int[] height) {
        int maxL = 0;
        int maxR = 0;

        int l = 0;
        int r = height.Length-1;
        int water = 0;
        while(l < r){
            if(height[r] >= height[l]){
                if(height[l] >= maxL)
                    maxL = height[l];
                else
                    {
                    int gap = maxL-height[l];
                    water = water + gap;
                    }
                    l++;
           }
           else {
                //focus on R
                if(height[r] >= maxR)
                    maxR = height[r];
                else
                    {
                    int gap = maxR-height[r];
                    water = water + gap;
                    }
                r--;
           }
        }
        return water;
    }
}
