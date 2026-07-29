public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int i = 0;
        int j = heights.Length - 1;
        while (i < j)
        {
            int currentArea = Math.Min(heights[i], heights[j]) * (j - i);
            result = Math.Max(result, currentArea); 
            if (heights[i] < heights[j]) {
                i++;
            }
            else
            {
                j--;
            }
        }
        return result;
    }
}
