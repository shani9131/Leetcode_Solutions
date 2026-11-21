import java.util.Arrays;

class Solution {
    public int[] findSubtreeSizes(int[] parent, String s) {
        int n = parent.length;
        int[] head = new int[n];
        int[] nxt = new int[n];
        int[] prev = new int[n];
        int[] order = new int[n];
        int[] stack = new int[n];
        int[] ans = new int[n];
        int[] last = new int[26];
        Arrays.fill(head, -1);
        Arrays.fill(nxt, -1);
        Arrays.fill(last, -1);

        for (int i = n - 1; i >= 1; i--) {
            nxt[i] = head[parent[i]];
            head[parent[i]] = i;
        }

        char[] c = s.toCharArray();
        int cnt = 0, top = 0;
        stack[top++] = 0;
        prev[0] = -1;
        last[c[0] - 'a'] = 0;
        order[cnt++] = 0;

        while (top > 0) {
            int u = stack[top - 1];
            int v = head[u];
            if (v != -1) {
                head[u] = nxt[v];
                int ch = c[v] - 'a';
                prev[v] = last[ch];
                last[ch] = v;
                order[cnt++] = v;
                stack[top++] = v;
            } else {
                last[c[u] - 'a'] = prev[u];
                top--;
            }
        }

        Arrays.fill(ans, 1);
        for (int k = n - 1; k >= 1; k--) {
            int x = order[k];
            int p = prev[x] != -1 ? prev[x] : parent[x];
            ans[p] += ans[x];
        }
        return ans;
    }
}