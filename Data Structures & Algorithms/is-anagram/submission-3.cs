public class Solution {
    public bool IsAnagram(string s, string t) {
    if(s.Length != t.Length)
        return false;
 
    int[] a  = new int[26]; //fixed array 0(1)

    for(int i=0;i<s.Length;i++){
        char letter = s[i];
        int slot = letter - 'a';
        a[slot]++;
    }
    for(int i=0;i<t.Length;i++){
        char letter = t[i];
        int slot = letter - 'a';
        a[slot]--;
    }

    foreach(int i in a){
        if(i != 0)
            return false;
    }
    return true;
    }
}
