//https://leetcode.com/problems/find-all-duplicates-in-an-array

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> result = new List<int>();
        HashSet<int> temp = new HashSet<int>();
        foreach(var i in nums){
            int count = temp.Count;
            temp.Add(i);
            if(temp.Count == count){
                result.Add(i);
            }
        }
        return result;
    }
}
