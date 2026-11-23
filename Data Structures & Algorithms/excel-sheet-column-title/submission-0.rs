impl Solution {
    pub fn convert_to_title(column_number: i32) -> String {
        let mut result_reversed = String::new();
        let mut n = column_number;
        while n > 0 {
            // Columns are 1-based (A=1, Z=26), so shift to 0-based before each digit.
            n -= 1;
            result_reversed.push((b'A' + (n % 26) as u8) as char);
            n /= 26;
        }
        result_reversed.chars().rev().collect()
    }
}
