impl Solution {
    pub fn max_area(heights: Vec<i32>) -> i32 {
        let mut left = 0usize;
        let mut right = heights.len() - 1;
        let mut max = 0i32;
        while left < right {
            max = i32::max(max, area(left, right, &heights));
            if heights[left] < heights[right] {
                left += 1;
            } else {
                right -= 1;
            }
        }
        return max;

        fn area(left: usize, right: usize, heights: &Vec<i32>) -> i32 {
            i32::min(heights[left], heights[right]) * (right - left) as i32
        }
    }
}
