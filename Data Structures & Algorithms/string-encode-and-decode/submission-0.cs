public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        if(strs.Count == 0 || strs == null) return string.Empty;
        foreach(var s in strs) {
            sb.Append(s.Length);
            sb.Append(":");
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        if(string.IsNullOrEmpty(s)) return new List<string>();
        int i =0;
        while(i < s.Length){
            int delimitedIndex = s.IndexOf(":",i);
            int length = int.Parse(s.Substring(i,delimitedIndex-i));
            i = delimitedIndex + 1;
            result.Add(s.Substring(i,length));
            i += length;
        }
        return result;
   }
}
