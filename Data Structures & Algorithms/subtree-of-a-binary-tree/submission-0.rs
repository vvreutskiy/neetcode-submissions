// Definition for a binary tree node.
// #[derive(Debug, PartialEq, Eq)]
// pub struct TreeNode {
//     pub val: i32,
//     pub left: Option<Rc<RefCell<TreeNode>>>,
//     pub right: Option<Rc<RefCell<TreeNode>>>,
// }
//
// impl TreeNode {
//     #[inline]
//     pub fn new(val: i32) -> Self {
//         TreeNode {
//             val,
//             left: None,
//             right: None,
//         }
//     }
// }

use std::rc::Rc;
use std::cell::RefCell;

impl Solution {
    pub fn is_subtree(
        root: Option<Rc<RefCell<TreeNode>>>,
        sub_root: Option<Rc<RefCell<TreeNode>>>,
    ) -> bool {
        if root.is_none() && sub_root.is_none() {
            return true;
        }
        let mut queue = VecDeque::new();
        queue.push_front(root);
        while !queue.is_empty() {
            if let Some(node) = queue.pop_back() {
                if node.as_ref().map(|n| n.borrow().val)
                    == sub_root.as_ref().map(|n| n.borrow().val)
                    && compare_subtree(&node, &sub_root)
                {
                    return true;
                } else {
                    if let Some(rc) = &node {
                        let n = rc.borrow();
                        queue.push_front(n.left.clone());
                        queue.push_front(n.right.clone());
                    }
                }
            }
        }

        return false;

        fn compare_subtree(
            left: &Option<Rc<RefCell<TreeNode>>>,
            right: &Option<Rc<RefCell<TreeNode>>>,
        ) -> bool {
            let mut queue = VecDeque::new();
            queue.push_front((left.clone(), right.clone()));
            while let Some((l, r)) = queue.pop_back() {
                match (l, r) {
                    (None, None) => {},
                    (Some(l), Some(r)) => {
                        let (l, r) = (l.borrow(), r.borrow());
                        if l.val != r.val {
                            return false;
                        }
                        queue.push_front((l.left.clone(), r.left.clone()));
                        queue.push_front((l.right.clone(), r.right.clone()))
                    },
                    _ => return false
                }
            }
            true
        }
    }
}
