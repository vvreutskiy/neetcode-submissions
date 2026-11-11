public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        return strs.GroupBy(k => new string( k.OrderBy(x => x).ToArray()), v => v).Select(x => x.ToList()).ToList();
    }
}
