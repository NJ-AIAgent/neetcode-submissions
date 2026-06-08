public class Solution {
    public bool IsPalindrome(string s) {
        //var str = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower(); 
        var sb = new StringBuilder();

        foreach(var c in s){
            if(char.IsLetterOrDigit(c)){
                sb.Append(c);
            }
        }

        var str = sb.ToString().ToLower();

        var rev = new string(str.Reverse().ToArray());

        if(str.Equals(rev))
            return true;
        else
            return false;
    }
}
