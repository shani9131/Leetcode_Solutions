class Solution {
public:
    int numOfSubarrays(vector<int>& arr) {
        int n = arr.size();
        unordered_map<int, int> mp;
        int mod = 1e9 + 7;

        mp[0] = 1;   
        int sum = 0;
        long long count = 0;

        for (int i = 0; i < n; i++) {
            sum += arr[i];
            int parity = sum % 2;

            count = (count + mp[1 - parity]) % mod;
            mp[parity]++;
        }

        return (int)count;
    }
};
