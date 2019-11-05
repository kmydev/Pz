using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        int ans = 0;
        for (int x = 1; x < m; x++)
        {
            for (int y = 1; y < n; y++)
            {
                int d = (int)(Math.Sqrt(x*x+y*y)*10000) % 10000;
                if (d == 0) ans++;
            }
        }
        Console.WriteLine(ans);
    }
}
