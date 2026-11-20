impl Solution {
    pub fn rotate(nums: &mut Vec<i32>, k: i32) {
        if nums.is_empty() {
            return;
        }
        let k = k as usize % nums.len();
        nums.reverse();
        nums[..k].reverse();
        nums[k..].reverse();
    }
}
