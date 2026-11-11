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
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
        var stack = new Stack<(TreeNode, int)>();
        int maxLevel = 1;
        stack.Push((root, 1));
        while (stack.Count > 0) {
            var (node, level) = stack.Pop();
            maxLevel = Math.Max(maxLevel, level);
            if (node.left != null)
                stack.Push((node.left, level + 1));
            if (node.right != null)
                stack.Push((node.right, level + 1));
        }
        return maxLevel;
    }
}
