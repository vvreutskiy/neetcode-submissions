impl Solution {
    pub fn asteroid_collision(asteroids: Vec<i32>) -> Vec<i32> {
        let mut stack = Vec::<i32>::new();
        for val in asteroids {
            loop {
                match stack.last() {
                    None => {
                        stack.push(val);
                        break;
                    },
                    // `&in_stack` copies the value, so `stack` is not borrowed when we pop
                    Some(&in_stack) => {
                        match (in_stack.is_positive(), val.is_positive(), in_stack + val) {
                            // no collision: same direction, or they move apart
                            (in_stack_pos, val_pos, _) if in_stack_pos == val_pos || !in_stack_pos => {
                                stack.push(val);
                                break;
                            },
                            // same size: both are destroyed
                            (_, _, 0) => {
                                stack.pop();
                                break;
                            },
                            // top is larger: `val` is destroyed
                            _ if in_stack.abs() > val.abs() => break,
                            // top is smaller: destroy it, `val` meets the next top
                            _ => {
                                stack.pop();
                            },
                        }
                    }
                }
            }
        }

        stack

    }
}
