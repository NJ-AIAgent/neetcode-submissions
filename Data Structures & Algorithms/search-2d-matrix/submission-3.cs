public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;        // 3
        int cols = matrix[0].Length;     // 4

        int low = 0;
        int high = rows * cols - 1;      // last flat index = 11

        while(low <= high){
            int mid = low + (high - low) / 2;

            // Flat array
            int value = matrix[mid / cols][mid % cols];

            if(value < target){
                low = mid + 1;
            }
            else if(value > target){
                high = mid - 1;
            }
            else{
                return true;
            }
        }
        return false;
    }
}