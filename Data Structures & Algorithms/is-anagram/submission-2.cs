public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        //var dict1 = s.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        //var dict2 = t.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        var dict1 = new Dictionary<char,int>();
        var dict2 = new Dictionary<char,int>();
        foreach(var s1 in s){
            dict1[s1] = dict1.GetValueOrDefault(s1,0)+1;
        }
        foreach(var t1 in t){
            dict2[t1] = dict2.GetValueOrDefault(t1,0)+1;
        }
        return dict1.All(kvp => dict2.TryGetValue(kvp.Key, out var val) && Equals(kvp.Value,val));
    }
}
