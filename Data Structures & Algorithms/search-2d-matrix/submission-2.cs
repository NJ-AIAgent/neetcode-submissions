public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int n = matrix[0].Length-1;
        
        for(int i=0;i<matrix.Length;i++){
    
            if(target >= matrix[i][0] && target <= matrix[i][n] )
             {
                int low =0; int high = n;
                 int mid;
                while(low <= high){
                     mid = low + (high-low)/2; 
                if(matrix[i][mid] < target){
                    low = mid + 1;
                   
                }
                else if(matrix[i][mid] > target){
                    high = mid -1;
                   
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
