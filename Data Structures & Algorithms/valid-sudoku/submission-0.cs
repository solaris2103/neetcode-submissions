public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<string>();
        for(var i = 0; i < 9; i++) {
            for(var j = 0; j < 9; j++) {
                char number = board[i][j];
                if(number != '.') {
                    var rowKey = $"{number} in row {i}";
                    var colKey = $"{number} in col {j}";
                    //var boxKey = $"{number} in box {i/3}-{j/3}";
                    var boxKey = $"{number} in box {(i/3)*3+(j/3)}";
                    if(!seen.Add(rowKey) || !seen.Add(colKey) || !seen.Add(boxKey))
                        return false;
                }
            }
        }
        return true;
    }
}
