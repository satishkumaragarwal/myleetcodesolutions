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
    public int CountNodes(TreeNode root) {
        if(root == null) return 0;
        TreeNode left = root.left;
        TreeNode right = root.right;
        int rLevel = 0, lLevel = 0;
        while(left != null){
            left = left.left;
            lLevel++;
        }
        while(right != null){
            right = right.right;
            rLevel++;
        }
        if(lLevel == rLevel) return (int)(Math.Pow(2,lLevel+1) -1);
        else return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}
