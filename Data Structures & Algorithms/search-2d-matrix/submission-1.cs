public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int n = matrix[0].Length-1;
        
        for(int i=0;i<matrix.Length;i++){
    
            if(target >= matrix[i][0] && target <= matrix[i][n] )
             {
                int low =0; int high = n;
                 int mid = low + (high-low)/2;
                while(low <= high){
                if(matrix[i][mid] < target){
                    low = mid + 1;
                    mid = low + (high-low)/2; 
                }
                else if(matrix[i][mid] > target){
                    high = mid -1;
                    mid = low + (high-low)/2;
                }
                else{
                    return true;
                }

             }
             }

        }
        return false;
    }
}
