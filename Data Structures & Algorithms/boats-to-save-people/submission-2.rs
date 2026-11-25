impl Solution {
    pub fn num_rescue_boats(people: Vec<i32>, limit: i32) -> i32 {
        let mut sorted_people = people.clone();
        sorted_people.sort();
        let mut left = 0usize;
        let mut right = sorted_people.len() - 1;
        let mut result = 0i32;
        while left < right {
            if sorted_people[left] + sorted_people[right] <= limit {
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
