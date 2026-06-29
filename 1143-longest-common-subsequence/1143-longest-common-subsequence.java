class Solution {
    Integer dp[][];
    public int longestCommonSubsequence(String text1, String text2) {
        dp=new Integer[text1.length()][text2.length()];

        return solve(0,0,text1,text2);


    }
    public int solve(int i, int j, String text1, String text2){
        if(i>=text1.length() ||j>=text2.length()) return 0;
        int take=0;
        int skip=0;

        if(dp[i][j]!=null) return dp[i][j];

        if(text1.charAt(i)==text2.charAt(j)){
            take=1+solve(i+1,j+1,text1,text2);
        }else{
        
            skip=Math.max(solve(i+1,j,text1,text2),solve(i,j+1,text1,text2));
        }
        dp[i][j]= Math.max(take,skip);
        return dp[i][j];
    }


    
}
  