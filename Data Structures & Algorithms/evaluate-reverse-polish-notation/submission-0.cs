public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++) {
            if (int.TryParse(tokens[i], out var val)) {
                stack.Push(val);
            } else {
                var right = stack.Pop();
                var left = stack.Pop();
                switch (tokens[i]) {
                    case "+":
                        stack.Push(left + right);
                        break;
                    case "*":
                        stack.Push(left * right);
                        break;
                    case "-":
                        stack.Push(left - right);
                        break;
                    case "/":
                        stack.Push(left / right);
                        break;
                }
            }
        }
        return stack.Pop();
    }
}
