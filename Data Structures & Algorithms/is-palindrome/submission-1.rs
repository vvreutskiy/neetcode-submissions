impl Solution {
    pub fn is_palindrome(s: String) -> bool {
        let chars = s.chars().filter(char::is_ascii_alphanumeric).map(|c| c.to_ascii_lowercase());
        chars.clone().eq(chars.rev())
    }
}
