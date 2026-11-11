public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0)
            return -1;
        if (nums is [int num])
            return nums[0] == target ? 0 : -1;

        int start = 0;
        int end = nums.Length - 1;
        int mid = (end - start) / 2 + start;
        do {
            if (nums[mid] == target)
                return mid;
            if (nums[mid] < target) {
                start = mid + 1;
            } else {
                end = mid;
            }
            mid = (end - start) / 2 + start;
        } while (start < end);
        return nums[mid] == target ? mid : -1;
    }
}
