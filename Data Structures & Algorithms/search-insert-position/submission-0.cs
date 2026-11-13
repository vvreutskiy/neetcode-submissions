public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var low = 0;
        var high = nums.Length;
        while (low < high) {
            var mid = low + (high - low) / 2;
            if (nums[mid] < target) {
                low = mid + 1;
            } else {
                high = mid;
            }
        }
        return low;
    }
}