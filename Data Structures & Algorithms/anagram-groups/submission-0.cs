public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        foreach(var s in strs){
            char[] splitStr = s.ToCharArray();
            Array.Sort(splitStr);
            string newValue = new string(splitStr);

            if(!result.TryGetValue(newValue, out var list)){
                list = new List<string>();
                result[newValue] = list;
            }
            list.Add(s);
        }
        return new List<List<string>>(result.Values);
    }
}
