public class Solution {
    public int FindMin(int[] nums) {
        ArgumentNullException.ThrowIfNull(nums);
        if (nums.Length == 0)
            throw new ArgumentException();

        var left = 0;
        var right = nums.Length - 1;

        while (left < right) {
            var mid = left + (right - left) / 2;

            if (nums[mid] > nums[right])
                left = mid + 1;
            else if (nums[mid] < nums[right])
                right = mid;
            else
                right--;
        }

        return nums[left];
    }
}
