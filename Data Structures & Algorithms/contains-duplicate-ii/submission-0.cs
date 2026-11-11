public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (k <= 0 || nums == null || nums.Length < 2)
            return false;
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i]))
                return true;
            dict[nums[i]] = i;
            if (i - k >= 0) {
                dict.Remove(nums[i - k]);
            }
        }
        return false;
    }
}