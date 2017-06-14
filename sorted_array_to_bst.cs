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
    public TreeNode SortedArrayToBST(int[] nums) {
        int i=0, j = nums.Length-1;
        TreeNode root = SortedArrayToBSTHelper(nums,i,j);
        return root;
    }
    
    private TreeNode SortedArrayToBSTHelper(int[] nums, int i, int j){
        if(i>j) return null;
        int mid = (i+j)/2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = SortedArrayToBSTHelper(nums, i, mid-1);
        root.right = SortedArrayToBSTHelper(nums, mid+1, j);
        return root;
    }
}
