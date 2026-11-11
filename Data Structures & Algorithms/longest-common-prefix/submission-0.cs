public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
            return "";
        if (strs.Length == 1)
            return strs[0];
        string currentCommonPrefix = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            currentCommonPrefix = CommonPrefix(currentCommonPrefix, strs[i]);
            if (currentCommonPrefix == "")
                return "";
        }

        return currentCommonPrefix;

        string CommonPrefix(string s1, string s2) {
            var minLength = Math.Min(s1.Length, s2.Length);
            for (int i = 0; i < minLength; i++) {
                if (s1[i] != s2[i])
                    return s1.Substring(0, i);
            }
            return s1.Length == minLength ? s1 : s1.Substring(0, minLength);
        }
    }
}