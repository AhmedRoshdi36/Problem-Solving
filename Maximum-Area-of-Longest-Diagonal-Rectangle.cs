public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int maxDiagonal = 0;
        int maxArea = 0;

        foreach (var rect in dimensions) {
            int length = rect[0];
            int width = rect[1];

            int diagonalSquared = length * length + width * width;
            int area = length * width;

            if (diagonalSquared > maxDiagonal || 
               (diagonalSquared == maxDiagonal && area > maxArea)) 
            {
                maxDiagonal = diagonalSquared;
                maxArea = area;
            }
        }

        return maxArea;
    }
}
