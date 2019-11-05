using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        int ans = 0;
        for (int i = 1; i <= 30; i++)
        {
            if (i * 3 < m && i * 4 < n) ans++;
            if (i * 4 < m && i * 3 < n) ans++;
            if (i * 5 < m && i * 12 < n) ans++;
            if (i * 12 < m && i * 5 < n) ans++;
            if (i * 8 < m && i * 15 < n) ans++;
            if (i * 15 < m && i * 8 < n) ans++;
            if (i * 7 < m && i * 24 < n) ans++;
            if (i * 24 < m && i * 7 < n) ans++;
            if (i * 21 < m && i * 20 < n) ans++;
            if (i * 20 < m && i * 21 < n) ans++;
        }
        Console.WriteLine(ans);
    }
}
