/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        TreeNode left = root.left;
        TreeNode right = root.right;
        root.left = InvertTree(right);
        root.right = InvertTree(left);
        return root;
    }
}
