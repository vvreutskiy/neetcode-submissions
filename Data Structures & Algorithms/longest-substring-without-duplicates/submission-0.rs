impl Solution {
    pub fn length_of_longest_substring(s: String) -> i32 {
        let mut hashmap: HashMap<char, usize> = HashMap::new();
        let mut left = 0usize;
        let mut max = 0usize;
        for (idx, c) in s.chars().enumerate() {
            match hashmap.insert(c, idx) {
                Some(existing_idx) if existing_idx >= left => left = existing_idx + 1,
                _ => {}
            }
            max = usize::max(max, idx - left + 1);
        }
        max as i32
    }
}
