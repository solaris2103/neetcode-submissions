public class Solution {
    public bool IsPalindrome(string s) {
        var sb = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(char.ToLowerInvariant(c));
            }
        }
        string formattedStr = sb.ToString();
        var rightPtr = formattedStr.Length-1;
        for(var leftPtr = 0; leftPtr < formattedStr.Length; leftPtr++){
              if(leftPtr < rightPtr){
                if(formattedStr[leftPtr] != formattedStr[rightPtr]) {
                    return false;
                }
                rightPtr--;
            }
            
        }
        return true;
    }
}
