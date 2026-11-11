public class Solution {
    public void ReverseString(char[] s) {
        if (s.Length <= 1)
            return;
        for (int i = 0; i < s.Length / 2; i++) {
            (s[i], s[s.Length - i - 1]) = (s[s.Length - i - 1], s[i]);
        }
    }
}