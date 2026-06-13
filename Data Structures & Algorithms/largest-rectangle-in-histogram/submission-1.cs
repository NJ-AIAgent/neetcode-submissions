public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxW = 0;
        
        for(int i=0;i<heights.Length;i++){
            int left = i;
            int right = i;

             while(left-1 >= 0){
                if(heights[left-1] >= heights[i])
                    left = left -1;
                else
                    break;
             }

             while(right+1 < heights.Length ){
             if(heights[right+1] >= heights[i])
                right = right + 1;
             else 
                break;
             }

            

             int area = heights[i] * (right-left+1);

             maxW = Math.Max(area,maxW );
        }
        return maxW;
        
    }
}
