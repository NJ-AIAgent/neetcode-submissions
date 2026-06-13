public class Solution {
    public int LargestRectangleArea(int[] heights) {
        
        var stack = new Stack<int>();
        int maxW= 0;

        for(int i=0;i<heights.Length;i++){
            while(stack.Count>0 && heights[i]<heights[stack.Peek()]){
                int eleindex = stack.Pop();
                int element = heights[eleindex];
                int nse = i;
                int pse;
                if(stack.Count == 0)
                    pse = -1;
                else 
                    pse = stack.Peek();
                maxW = Math.Max(maxW,element * (nse-pse-1));
            }
            stack.Push(i);   
        }
        while(stack.Count > 0){
            int ele = heights[stack.Pop()];
            int nse = heights.Length;
            int pse;
            if(stack.Count == 0)
                    pse = -1;
                else 
                    pse = stack.Peek();
            maxW = Math.Max(maxW,ele * (nse-pse-1)); 
        }
    return maxW;
    }

}
