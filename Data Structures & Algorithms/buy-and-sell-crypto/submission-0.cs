public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int max = int.MinValue;
        int profit = 0;
        for(int i = 0; i< prices.Length-1; i++){
            for(int j = i+1; j< prices.Length;j++){
                min = Math.Min(min,prices[i]);
                max = Math.Max(max,prices[j]);

                if(min < max){
                    profit = Math.Max(profit, prices[j]-prices[i]); 
                }
            }
        }
        return profit;
    }
}
