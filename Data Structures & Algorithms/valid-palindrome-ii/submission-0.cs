public class Solution {
    public bool ValidPalindrome(string s) {
        if (s == null || s.Length <= 1)
            return true;

        int left = 0, right = s.Length - 1;
        // first pass
        bool foundError = false;
        while (left < right) {
            while (!char.IsLetterOrDigit(s[left])) left++;
            while (!char.IsLetterOrDigit(s[right])) right--;
            if (s[left] != s[right]) {
                foundError = true;
                break;
            }
            left++;
            right--;
        }
        if (!foundError)
            return true;
        foundError = false;
        var newLeft = left + 1;
        var newRight = right;
        while (newLeft < newRight) {
            while (!char.IsLetterOrDigit(s[left])) left++;
            while (!char.IsLetterOrDigit(s[right])) right--;
            if (s[newLeft] != s[newRight]) {
                foundError = true;
                break;
            }
            newLeft++;
            newRight--;
        }
        if (!foundError)
            return true;
        foundError = false;
        newLeft = left;
        newRight = right - 1;
        while (newLeft < newRight) {
            while (!char.IsLetterOrDigit(s[left])) left++;
            while (!char.IsLetterOrDigit(s[right])) right--;
            if (s[newLeft] != s[newRight]) {
                foundError = true;
                break;
            }
            newLeft++;
            newRight--;
        }
        return !foundError;
    }
}