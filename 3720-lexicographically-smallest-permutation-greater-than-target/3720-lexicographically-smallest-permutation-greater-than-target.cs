public class Solution {
    public string LexGreaterPermutation(string s, string target) {
        int[] cnt = new int[26];
        for (int i = 0; i < s.Length; i++) {
            cnt[s[i] - 'a']++;
            cnt[target[i] - 'a']--;
        }

        // Try from right to left
        char[] t = target.ToCharArray();
        for (int i = s.Length - 1; i >= 0; i--) {
            int b = t[i] - 'a';
            cnt[b]++;  // Reversal of consumption
            // Check if the prefix can fully match
            if (cnt.Min() < 0) {
                continue;
            }
            // Find the smallest available character larger than b.
            for (int j = b + 1; j < 26; j++) {
                if (cnt[j] > 0) {
                    cnt[j]--;
                    t[i] = (char)('a' + j);
                    return new string(t, 0, i + 1) + GetMinString(cnt);
                }
            }
        }

        return "";
    }

    // Get the lexicographically smallest string (in ascending order)
    private string GetMinString(int[] cnt) {
        StringBuilder res = new StringBuilder();
        for (int i = 0; i < 26; i++) {
            res.Append(new string((char)('a' + i), cnt[i]));
        }
        return res.ToString();
    }
}