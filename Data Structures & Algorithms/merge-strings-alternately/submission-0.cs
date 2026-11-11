public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var longer = word1.Length > word2.Length ? word1 : word2;
        var minLenght = Math.Min(word1.Length, word2.Length);
        StringBuilder sb = new(word1.Length + word2.Length);
        int i;
        for (i = 0; i < minLenght; i++) {
            sb.Append(word1[i]);
            sb.Append(word2[i]);
        }
        sb.Append(longer[i..]);
        return sb.ToString();
    }
}