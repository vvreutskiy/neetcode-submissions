public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach (var c in s) {
            if (stack.Count == 0) {
                stack.Push(c);
                continue;
            }

            switch (stack.Peek(), c) {
                case ('[', ']'):
                case ('(', ')'):
                case ('{', '}'):
                    stack.Pop();
                    break;
                default:
                    stack.Push(c);
                    break;
            }
        }

        return stack.Count == 0;
    }
}
