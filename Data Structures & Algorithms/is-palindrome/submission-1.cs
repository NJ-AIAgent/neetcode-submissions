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
        int i = 0; 
        int j = str.Length-1;
        while(j>i){
            if(str[i] != str[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
