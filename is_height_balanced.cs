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
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        int diff = IsBalancedHelper(root);
        if(diff<0) return false;
        return true;
    }
    
    private int IsBalancedHelper(TreeNode root){
        if(root == null) return 0;
        else if((root.left == null && root.right == null)) return 1;
        int left = IsBalancedHelper(root.left);
        int right = IsBalancedHelper(root.right);
        if(left == -1 || right == -1) return -1;
        int output = left + right -2*Math.Min(left,right);
        if(output > 1){
            return -1;
        }
        else {
            return Math.Max(left,right)+1;
        }
    }
}
