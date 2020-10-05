import java.util.*;
public class NCR2 {
    static int solution(int[] a,int[] b){
        int mx=0,mi=0;
        for (int i = 0; i <a.length ; i++) {
            for (int j:b ) {
                if(a[i]==j){
                    if (a[i]>mx){
                        mx=a[i];
                    }
                    if (a[i]<mi || mi==0){
                        mi=a[i];
                    }
                }
            }
        }
        return mx-mi;
    }
    public static void main(String[] arr){
        int n=3,m=3;
        int[] a={1,3,5};
        int[] b={4,2,10};
        System.out.println(NCR2.solution(a,b));
    }
}
