public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            while (nums[i] >= 1 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i]) {
                var target = nums[i] - 1;
                var temp = nums[target];
                nums[target] = nums[i];
                nums[i] = temp;
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != i + 1)
                return i + 1;
        }

        return nums.Length + 1;
    }
}