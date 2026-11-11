public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>(nums.Length);
        for(int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dict.TryGetValue(nums[i], out var existingIdx)) return [existingIdx, i];
            dict[complement] = i;
        }
        throw new ArgumentException("can't find", nameof(nums));
    }
}
