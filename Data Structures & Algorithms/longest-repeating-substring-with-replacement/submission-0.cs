public class Solution {
    public int CharacterReplacement(string s, int k) {
    var dict = new Dictionary<char, int>();
    int start = 0, maxLen = 0, maxCount = 0;

    for (int end = 0; end < s.Length; end++) {
        // step 1: add to dict
        if (dict.TryGetValue(s[end], out int freq))
            dict[s[end]] = freq + 1;
        else
            dict[s[end]] = 1;

        // step 2: update maxCount
        maxCount = Math.Max(maxCount, dict[s[end]]);

        // step 3: shrink while invalid
        while (end - start + 1 - maxCount > k) {
            dict[s[start]]--;
            start++;
        }

        // step 4: record
        maxLen = Math.Max(maxLen, end - start + 1);
    }
    return maxLen;
}
}
