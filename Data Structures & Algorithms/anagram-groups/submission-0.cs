public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,List<string>>();

        foreach(var s in strs){
            var chars = s.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if(!dict.TryGetValue(key, out var list)){
                list = new List<string>();
                dict[key] = list;
            }
            list.Add(s);
        }

        return dict.Values.ToList();
    }
}
