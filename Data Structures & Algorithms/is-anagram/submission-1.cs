public class Solution {
    public bool IsAnagram(string s, string t) {
        s = s.ToLower();
        t = t.ToLower();
        if (s.Length != t.Length) {
            return false;
        }
        var dictionary = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) 
        {
            var keyToSave = s[i]; 
            dictionary[keyToSave] = dictionary.GetValueOrDefault(keyToSave) + 1;
        }

        for (int i = 0; i < t.Length; i++) {
            if (!dictionary.ContainsKey(t[i])) {
                return false;
            }

            dictionary[t[i]]--;
            if (dictionary[t[i]] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
