public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out var exists))
            {
                dict[nums[i]] = exists + 1;
            }
            else
            {
                dict[nums[i]] = 1;

            }

        }
        return dict.OrderByDescending(d => d.Value).Take(k).Select(d => d.Key).ToArray();
    }
}
