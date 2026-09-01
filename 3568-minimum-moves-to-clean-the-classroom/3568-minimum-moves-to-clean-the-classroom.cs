public class Solution {
    static readonly int[] dx = new int[] { 0, 1, 0, -1 };
    static readonly int[] dy = new int[] { 1, 0, -1, 0 };

    public int MinMoves(string[] classroom, int energy) {
        int m = classroom.Length;
        int n = classroom[0].Length;
        int[,] id = new int[m, n];
        int sx = 0, sy = 0, cnt = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                char c = classroom[i][j];
                if (c == 'S') {
                    sx = i;
                    sy = j;
                } else if (c == 'L') {
                    id[i, j] = 1 << cnt;
                    cnt++;
                }
            }
        }
        int full = 1 << cnt;
        int[,,] bestEnergy = new int[m, n, full];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                for (int k = 0; k < full; k++) {
                    bestEnergy[i, j, k] = -1;
                }
            }
        }
        bestEnergy[sx, sy, 0] = energy;

        var q = new Queue<(int x, int y, int mask, int e, int steps)>();
        q.Enqueue((sx, sy, 0, energy, 0));
        while (q.Count > 0) {
            var t = q.Dequeue();
            if (t.mask == full - 1) {
                return t.steps;
            }
            if (t.e == 0) {
                continue;
            }
            for (int d = 0; d < 4; d++) {
                int nx = t.x + dx[d];
                int ny = t.y + dy[d];
                if (nx < 0 || nx >= m || ny < 0 || ny >= n ||
                    classroom[nx][ny] == 'X') {
                    continue;
                }
                int ne = classroom[nx][ny] == 'R' ? energy : t.e - 1;
                int nmask = t.mask | id[nx, ny];
                if (ne > bestEnergy[nx, ny, nmask]) {
                    bestEnergy[nx, ny, nmask] = ne;
                    q.Enqueue((nx, ny, nmask, ne, t.steps + 1));
                }
            }
        }
        return -1;
    }
}