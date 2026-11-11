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
    public List<int> PostorderTraversal(TreeNode root) {
        if (root == null) return [];
        List<int> result = [];
        Stack<TreeNode> stack = new();
        TreeNode? current = root;
        TreeNode? lastVisited = null;
        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            var node = stack.Peek();
            if (node.right != null && lastVisited != node.right)
            {
                current = node.right;
            }
            else
            {
                result.Add(node.val);
                lastVisited = stack.Pop();
            }
        }

        return result;
    }
}