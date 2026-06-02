public class Solution {
    public bool IsAnagram(string s, string t) {
     if (s.Length != t.Length) return false;
     var sortedS = s.OrderBy(c => c);
     var sortedT = t.OrderBy(c => c);
     return sortedS.SequenceEqual(sortedT);
    }
}
