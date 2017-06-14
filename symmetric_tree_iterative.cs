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
    public bool IsSymmetric(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        TreeNode delimiter = new TreeNode(Int32.MaxValue);
        q.Enqueue(delimiter);
        List<int> lst = new List<int>();
        while(q.Count > 1){
            TreeNode temp = q.Dequeue();
            if(temp == null){
                lst.Add(-1);
                continue;
            }
            if(temp.val == Int32.MaxValue){
                q.Enqueue(delimiter);
                int n = lst.Count;
                for(int i=0,j=n-1;i<n/2;i++,j--){
                    if(lst[i] != lst[j])
                        return false;
                }
                lst.Clear();
            }
            else{
                lst.Add(temp.val);
                q.Enqueue(temp.left);
                q.Enqueue(temp.right);
            }
        }
        return true;
    }
}
