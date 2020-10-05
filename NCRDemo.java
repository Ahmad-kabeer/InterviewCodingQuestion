import java.util.Scanner;

public class NCRDemo {
    public static void main(String[] arg){
        Scanner sc=new Scanner(System.in);
        int len=sc.nextInt();       //3
        int[] array=new int[len];       //12,11,13
        for (int i = 0; i <len ; i++) {
            array[i]=sc.nextInt();
        }

        int min=array[0];
        for (int i:array) {
            if(i<min){
                min=i;;
            }
        }
        System.out.println(min);        //11
    }
}
