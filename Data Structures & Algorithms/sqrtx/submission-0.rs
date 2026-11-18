impl Solution {
    pub fn my_sqrt(x: i32) -> i32 {
        if x <= 1 {
            return x;
        }
        let mut left = 1;
        let mut right = x / 2;
        while left < right {
            let mid = left + (right - left) / 2;
            if mid <= x / mid && (mid + 1) > x /  (mid + 1) {
                return mid;
            } else if mid < x / mid {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        right
    }
}
