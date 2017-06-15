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
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> result = new List<string>();
        BinaryTreePathsHelper(root,result,"");
        return result;
    }
    
    private void BinaryTreePathsHelper(TreeNode root, IList<string> result, string prefix){
        if(root == null) return;
        if(root.left == null && root. right == null){
            result.Add(prefix + root.val);
            return;
        }
        BinaryTreePathsHelper(root.left, result, prefix + root.val + "->");
        BinaryTreePathsHelper(root.right, result, prefix + root.val + "->");
    }
}
