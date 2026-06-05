public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        foreach(var a in nums){         
            dict.TryGetValue(a, out var count);
            dict[a] = count+1;
           }

        return dict.OrderByDescending(pair => pair.Value)
                    .Take(k).Select(pair => pair.Key).ToArray();

    }
}
