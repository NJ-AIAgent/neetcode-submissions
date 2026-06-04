public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        var sa = s.ToArray();
        Array.Sort(sa);
        var ta = t.ToArray();
        Array.Sort(ta);
        for(int i = 0; i<sa.Length;i++){         
               if(sa[i]!=ta[i]){
                return false;
               }
            }
            return true;
        }
    }
