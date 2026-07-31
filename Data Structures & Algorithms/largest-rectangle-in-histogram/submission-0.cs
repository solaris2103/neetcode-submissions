public class Solution {
    public int LargestRectangleArea(int[] heights) {
        if (heights == null || heights.Length == 0) return 0;
        
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        int n = heights.Length;

        for (int i = 0; i <= n; i++) 
        {
            int currentHeight = (i == n) ? 0 : heights[i];
            while (stack.Count > 0 && currentHeight < heights[stack.Peek()]) 
            {
                int height = heights[stack.Pop()];
                int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, height * width);
            }
            stack.Push(i);
        }
        return maxArea;
    }
}
