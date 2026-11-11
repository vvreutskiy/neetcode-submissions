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
        var stack = new Stack<(TreeNode node, bool visited)>();
        var heights = new Dictionary<TreeNode, int>();
        stack.Push((root, false));
        while (stack.Count > 0) {
            var (node, visited) = stack.Pop();
            if (!visited) {
                stack.Push((node, true));
                if (node.left != null)
                    stack.Push((node.left, false));
                if (node.right != null)
                    stack.Push((node.right, false));
                continue;
            }
            var leftHeight = node.left != null ? heights[node.left] : 0;
            var rightHeight = node.right != null ? heights[node.right] : 0;
            if (Math.Abs(leftHeight - rightHeight) > 1)
                return false;
            heights[node] = Math.Max(leftHeight, rightHeight) + 1;
        }
        return true;
    }
}

