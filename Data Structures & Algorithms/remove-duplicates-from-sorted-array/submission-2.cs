public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
            return 0;
        var len = 0;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[len]) {
                len++;
                nums[len] = nums[i];
            }
        }
        return len + 1;
    }
}