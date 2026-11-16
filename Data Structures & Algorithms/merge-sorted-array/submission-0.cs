public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int nums1Idx = m - 1;
        int nums2Idx = n - 1;
        int currentPosIdx = m + n - 1;
        while (nums1Idx >= 0 && nums2Idx >= 0) {
            if (nums1[nums1Idx] > nums2[nums2Idx]) {
                nums1[currentPosIdx] = nums1[nums1Idx];
                nums1Idx--;
            } else {
                nums1[currentPosIdx] = nums2[nums2Idx];
                nums2Idx--;
            }
            currentPosIdx--;
        }

        while (nums2Idx >= 0) {
            nums1[currentPosIdx] = nums2[nums2Idx];
            currentPosIdx--;
            nums2Idx--;
        }
    }
}