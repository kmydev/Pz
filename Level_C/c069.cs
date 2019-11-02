using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int y = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        int d = int.Parse(arr[2]);
        arr = Console.ReadLine().Trim().Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        
        // 年 
        int ny = getNextYear(y);

        int ans = getRestDays(m, d) + ((ny - y - 1) * 181) + getDayOfYear(a, b);
        Console.WriteLine(ans);
    }
    
    private static int getNextYear(int y)
    {
        return ((y + 3) / 4) * 4 + 1;
    }
    
    private static int getDayOfYear(int m, int d)
    {
        m = m - 1;
        int nm = 13 * ((m + 1) / 2);
        nm += 15 * (m / 2);
        return nm + d;
    }
    
    private static int getRestDays(int m, int d)
    {
        return 181 - getDayOfYear(m, d);
    }
}
