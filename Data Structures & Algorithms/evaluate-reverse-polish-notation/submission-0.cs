public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int op2 = stack.Pop();
                int op1 = stack.Pop();
                int result = token switch
                {
                    "+" => op1 + op2,
                    "-" => op1 - op2,
                    "*" => op1 * op2,
                    "/" => op1 / op2,
                    _ => throw new ArgumentException($"Invalid operator: {token}")
                };
                stack.Push(result);
            }
        }
        return stack.Pop();
    }
}
