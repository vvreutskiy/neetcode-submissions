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
    public bool IsBalanced(TreeNode root) {
        if (root == null)
            return true;

        var (_, balanced) = TreeHeight(root);
        return balanced;

        (int height, bool balanced) TreeHeight(TreeNode node) {
            if (node == null)
                return (0, true);
            var left = TreeHeight(node.left);
            var right = TreeHeight(node.right);
            var balanced =
                Math.Abs(left.height - right.height) <= 1 && left.balanced && right.balanced;
            if (!balanced)
                return (0, false);
            var height = Math.Max(left.height, right.height) + 1;
            return (height, balanced);
        }
    }
}
