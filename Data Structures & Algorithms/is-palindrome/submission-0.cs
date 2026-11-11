public class Solution
{
    public bool IsPalindrome(string s)
    {
        for(int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            while(i < j && !OkChar(s[i])) i++;
            while(i < j && !OkChar(s[j])) j--;
            if (char.ToUpperInvariant(s[i]) != char.ToUpperInvariant(s[j])) return false;
        }
        return true;
    }
    
    private static bool OkChar(char c) => char.IsAsciiLetterOrDigit(c);
}