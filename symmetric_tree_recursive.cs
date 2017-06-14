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
        Dictionary<int,List<int>> hash = new Dictionary<int,List<int>>();
        IsSymmetricHelper(root,hash,1);
        foreach(var entry in hash){
            var lst = entry.Value;
            int n = lst.Count;
            for(int i=0,j=n-1;i<n/2;i++,j--){
                if(lst[i] != lst[j])
                    return false;
            }
        }
        return true;
    }
    
    public void IsSymmetricHelper(TreeNode root, Dictionary<int,List<int>> hash, int level){
        int val;
        if(root == null){
            val = Int32.MaxValue;
        }
        else {
            val = root.val;
        }
        if(!hash.ContainsKey(level)){
            List<int> lst = new List<int>();
            lst.Add(val);
            hash.Add(level,lst);
        }
        else{
            var lst = hash[level];
            lst.Add(val);
            hash[level] = lst;
        }
        if(root != null){
            IsSymmetricHelper(root.left, hash, level+1);
            IsSymmetricHelper(root.right, hash, level+1);
        }
    }
}
