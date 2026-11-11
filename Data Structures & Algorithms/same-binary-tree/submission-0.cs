/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        if ((p == null) != (q == null))
            return false;
        var stack = new Stack<(TreeNode, TreeNode)>();
        stack.Push((p, q));
        while (stack.Count() != 0) {
            var (pInner, qInner) = stack.Pop();
            if (pInner.val != qInner.val || (pInner.left == null) != (qInner.left == null) ||
                (pInner.right == null) != (qInner.right == null))
                return false;
            if (pInner.left != null)
                stack.Push((pInner.left!, qInner.left!));
            if (pInner.right != null)
                stack.Push((pInner.right!, qInner.right!));
        }
        return true;
    }
}
