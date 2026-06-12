public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];

        for(int i=0;i<temperatures.Length;i++){
            for(int j=i+1;j<temperatures.Length;j++){
                if(temperatures[j] > temperatures[i]){
                    result[i] = j-i;
                    break;
                }
            }
        }
        return result; 
        
    }
}
