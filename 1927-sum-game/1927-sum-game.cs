public class Solution
{
    public bool SumGame(string num)
    {
        int half = num.Length / 2;
        int s1 = 0, s2 = 0, q1 = 0, q2 = 0;

        for (int i = 0; i < half; i++)
        {
            char c1 = num[i];
            char c2 = num[i + half];

            if (c1 == '?')
                q1++;
            else
                s1 += c1 - '0';

            if (c2 == '?')
                q2++;
            else
                s2 += c2 - '0';
        }

        return (q1 + q2) % 2 != 0 || (s1 - s2) * 2 != (q2 - q1) * 9;
    }
}