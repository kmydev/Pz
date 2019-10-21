using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int d = int.Parse(arr[1]);
        Console.WriteLine((isDoublet(m, d)) ? "Yes" : "No");
    }
    
    private static bool isDoublet(int m, int d)
    {
        bool ret = false;

        if (m < 10 && m == d) ret = true; // 1/1, ... 9/9
        if (m <= 2 && m * 11 == d) ret = true; // 1-11, 2-22
        if (m == 11 && (d == 1 || d == 11)) ret = true; // 11-1, 11/11

        return ret;
    }
}
