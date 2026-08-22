public class Solution {
    public bool CheckDivisibility(int n) {
        // if(n==1){
        //     return true;
        // }
        int r=n;
        int ds=0;
        int dp=1;
        int sum=0;
        

        while(r!=0){
            int m=r%10;
            ds+=m;
            dp*=m;
            r=r/10;

        }
        sum=ds+dp;
        if(n%sum==0){
            return true;
        }else{
            return false;
        }
        
    }
}