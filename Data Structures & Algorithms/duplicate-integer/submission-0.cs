public class Solution {
    public bool hasDuplicate(int[] nums) {
        //return nums.Distinct().Count() != nums.Length;
        var set = new HashSet<int>();
        foreach(var n in nums){
            if(!set.Add(n)){
                return true;
            }
        }
        return false;
    }
}