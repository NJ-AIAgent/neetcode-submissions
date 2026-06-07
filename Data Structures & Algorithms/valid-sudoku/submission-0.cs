public class Solution {
    public bool IsValidSudoku(char[][] board) {

       int rows = board.Length;
       int cols = board[0].Length;
       for(int i = 0;i<rows;i++){
            HashSet<char> seen = new HashSet<char>();   
            for(int j=0;j<cols;j++){
                if(board[i][j] == '.') continue;
                if(seen.Contains(board[i][j])) return false;
                seen.Add(board[i][j]);
                
            }
        }

        for(int j = 0;j<cols;j++)
        {
            HashSet<char> seen = new HashSet<char>();   
            for(int i=0;i<rows;i++){
                if(board[i][j] == '.') continue;
                if(seen.Contains(board[i][j])) return false;
                seen.Add(board[i][j]);
                
            }
        }

        for (int square = 0; square < 9; square++) {
            HashSet<char> seen = new HashSet<char>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    if (board[row][col] == '.') continue;
                    if (seen.Contains(board[row][col])) return false;
                    seen.Add(board[row][col]);
                }
            }
        }
        return true;
    }
}