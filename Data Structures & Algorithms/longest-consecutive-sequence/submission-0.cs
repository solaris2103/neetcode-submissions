public class Solution {
    public int LongestConsecutive(int[] nums) {
        int count = 0;
        var set = new HashSet<int>();
        foreach(var n in nums) {
            set.Add(n);
        }
        int longestSeq = 0;
        foreach (var s in set){
            if(!set.Contains(s-1)) {
                int currentNum = s;
                int currentSeq = 1;
                while(set.Contains(currentNum+1)){
                    currentNum++;
                    currentSeq++;
                }
                longestSeq = Math.Max(currentSeq,longestSeq);
            }
        }
        return longestSeq;
    }
}
