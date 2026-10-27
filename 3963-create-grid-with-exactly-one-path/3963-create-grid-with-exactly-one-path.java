class Solution {
    public String[] createGrid(int m, int n) {
        char[][] temp=new char[m][n];

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                temp[i][j]='#';
            }
            
        }
        int a=0,b=0;
        temp[0][0]='.';

        while(a<m-1 || b<n-1){
            if(b<n-1){
                b++;
                temp[a][b]='.';
            }

            if(a<m-1){
                a++;
                temp[a][b]='.';
            }
        }

        String[] ans=new String[m];

        for(int i=0;i<m;i++){
            ans[i]=new String(temp[i]);
        }
        return ans;
        
    }
}