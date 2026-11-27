impl Solution {
    pub fn search_matrix(matrix: Vec<Vec<i32>>, target: i32) -> bool {
        let (mut left, mut right) = (0usize, matrix.len() * matrix[0].len());
        while left < right {
            let mid = left + (right - left) / 2;
            let mid_val = matrix[mid / matrix[0].len()][mid % matrix[0].len()];
            if mid_val == target {
                return true;
            } else if mid_val < target {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        false
    }
}
