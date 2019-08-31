using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        int x = int.Parse(arr[2]);
        int[] w_M = new int[m];

        for (int i = 0; i < m; i++)
        {
            w_M[i] = int.Parse(Console.ReadLine().Trim());
        }
        
        int cnt = 0;
        int tx = x;
        for (int i = 1; i <= m; i++)
        {
            tx -= w_M[i-1];
            if (tx > 0)
            {
                cnt++;
            }
            else
            {
                tx = x;
                n--;
                i--;
                if (n <= 0) break;            
            }

            //Console.WriteLine("i={0},n={1},tx={2},w_M[i]={3},cnt={4}", i, n, tx, w_M[i], cnt);
        }
        
        Console.WriteLine(cnt);
    }
}
