public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int start = 0;
        int length = 0;
        var window = new HashSet<char>();

        for(int end = 0 ; end < s.Length ; end++){
                while(window.Contains(s[end])){
                    window.Remove(s[start]);
                    start++;
                }
            window.Add(s[end]);
            length = Math.Max(length, end-start+1);
        }
         return length;
    }
}
