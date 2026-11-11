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
    public int DiameterOfBinaryTree(TreeNode root) {
        var (_, maxDiameter) = DiameterOfNode(root);
        return maxDiameter;
    }

    private (int subtreeHeight, int maxDiameter) DiameterOfNode(TreeNode node) {
        if (node == null)
            return (0, 0);

        var (leftHeight, bestLeft) = DiameterOfNode(node.left);
        var (rightHeight, bestRight) = DiameterOfNode(node.right);
        var currentDiameter = leftHeight + rightHeight;
        var subtreeHeight = Math.Max(leftHeight, rightHeight) + 1;
        return (subtreeHeight, Math.Max(currentDiameter, Math.Max(bestLeft, bestRight)));
    }
}
