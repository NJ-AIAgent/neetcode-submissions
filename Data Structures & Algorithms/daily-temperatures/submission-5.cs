public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var result = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++) {
            // today answers every waiting day it beats
            while (stack.Count > 0) {
                int topIndex = stack.Peek();
                int topTemp = temperatures[topIndex];

                if (temperatures[i] <= topTemp) break;

                if(temperatures[i] > topTemp){
                    int waitingDay = stack.Pop();
                    result[waitingDay] = i - waitingDay;
                }
            }    
            stack.Push(i);   
        }
        return result;
    }
}
