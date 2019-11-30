using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        int x = int.Parse(arr[2]);
        
        int [] warr = new int[m];
        for (int i = 0; i < m; i++)
        {
            warr[i] = int.Parse(Console.ReadLine().Trim());
        }

        int ans = 0;
        int tm = 0;
        for (int i = 0; i < n; i++)
        {
            int tx = x;
            while (tm < m)
            {
                tx -= warr[tm];
                if (tx > 0)
                {
                    ans++;
                    tm++;
                }
                else
                {
                    break;
                }
            }
        }

        System.Console.WriteLine(ans);
    }
}
