impl Solution {
    pub fn remove_duplicates(nums: &mut Vec<i32>) -> i32 {
        if nums.len() <= 1 {
            return nums.len() as i32;
        }
        let mut slow: usize = 0;
        let mut last_val: i32 = nums[0];
        for fast in 1..nums.len() {
            if nums[fast] != last_val {
                last_val = nums[fast];
                slow += 1;
                nums[slow] = last_val;
            }
        }
        slow as i32 + 1
    }
}
