public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length)
            return "";

        for(int i = 0; i < t.Length; i++){
            if(!s.Contains(t[i]))
                return "";
        }

        var need = new Dictionary<char, int>();
        for(int i = 0; i < t.Length; i++){
            need[t[i]] = need.GetValueOrDefault(t[i], 0) + 1;
        }

        int required = need.Count;
        var window = new Dictionary<char, int>();
        int start = 0;
        int have = 0;
        int minWindow = s.Length+1;
        int minStart = 0;             // ← track best window start

        for(int end = 0; end < s.Length; end++){
            window[s[end]] = window.GetValueOrDefault(s[end], 0) + 1;  // ← s[end] not t[end]

            if(need.ContainsKey(s[end]) && window[s[end]] == need[s[end]]){
                have++;
            }

            while(have == required){
                if(end - start + 1 < minWindow){
                    minWindow = end - start + 1;
                    minStart = start;  // ← save start before it moves
                }

                window[s[start]]--;
                if(need.ContainsKey(s[start]) && window[s[start]] < need[s[start]])
                    have--;
                start++;
            }
        }

        return minWindow == s.Length + 1 ? "" : s.Substring(minStart, minWindow);
    }
}