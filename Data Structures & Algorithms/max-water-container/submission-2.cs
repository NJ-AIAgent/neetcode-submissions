public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;


        int i = 0;
        int j= heights.Length-1;
        while(j>i){
            var min = Math.Min(heights[i],heights[j]);
            var maxValue = min * (j-i);
            max = Math.Max(max,maxValue);
            if(heights[i]>heights[j])
                j--;
            else
                i++;
           
        }
        return max;
    }
}
