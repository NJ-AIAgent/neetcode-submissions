public class Solution {
    public bool CheckInclusion(string s1, string s2) {
       if(s1.Length > s2.Length) return false;

       int[] s1FreqArray = new int[26];
        int[] s2FreqArray = new int[26]; // window 

       for(int i=0;i<s1.Length;i++){
         s1FreqArray[s1[i] - 'a']++;
         s2FreqArray[s2[i] - 'a']++;
       } 

     if(s1FreqArray.SequenceEqual(s2FreqArray)) return true;

     int start = 0;
     int end = s1.Length-1;

    for(end = s1.Length; end < s2.Length ; end++){
        s2FreqArray[s2[end] - 'a']++;
        s2FreqArray[s2[start] - 'a']--;
        start++;
    
    
     if(s1FreqArray.SequenceEqual(s2FreqArray)) 
     return true;
    }
    return false;
    }
}
