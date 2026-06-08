public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        int i =0;
        int j= n-1;
        while(i<j){
            if(numbers[i] + numbers[j] > target)
                j--;
            else if(numbers[i] + numbers[j] < target)
                i++;
            else
                return new int[]{i+1,j+1};
        }
    return new int[]{};
    }
}
