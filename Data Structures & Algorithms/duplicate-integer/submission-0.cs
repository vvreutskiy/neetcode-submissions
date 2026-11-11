public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>(nums);
        return set.Count != nums.Length;
    }
}