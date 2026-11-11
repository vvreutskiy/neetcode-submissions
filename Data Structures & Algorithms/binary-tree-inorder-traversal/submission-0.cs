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
    public List<int> InorderTraversal(TreeNode root) {
        if (root == null) return [];
        List<int> left = [], right = [];
        if (root.left != null)
            left = InorderTraversal(root.left);
        if (root.right != null)
            right = InorderTraversal(root.right);
        return [..left, root.val, ..right];
    }
}