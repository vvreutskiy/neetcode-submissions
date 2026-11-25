impl Solution {
    pub fn num_rescue_boats(mut people: Vec<i32>, limit: i32) -> i32 {
        people.sort();
        let mut left = 0usize;
        let mut right = people.len() - 1;
        let mut result = 0i32;
        while left < right {
            if people[left] + people[right] <= limit {
                result += 1;
                left +=1;
                right -= 1;
            } else {
                result += 1;
                right -= 1;
            }
        }
        if left == right {
            result += 1
        }
        result
    }
}
