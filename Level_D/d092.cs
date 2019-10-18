using System;
using System.Text;

public class Pz{
    public static void Main(){
        string s1 = Console.ReadLine().Trim();
        var arr = s1.Split(' ');
        int x1 = int.Parse(arr[0]);
        int y1 = int.Parse(arr[1]);
        int p1 = int.Parse(arr[2]);
        float a1 = (float)p1 / ((float)x1 * (float)y1);

        string s2 = Console.ReadLine().Trim();
        arr = s2.Split(' ');
        int x2 = int.Parse(arr[0]);
        int y2 = int.Parse(arr[1]);
        int p2 = int.Parse(arr[2]);
        float a2 = (float)p2 / ((float)x2 * (float)y2);

        string ans = (a1 == a2) ? "DRAW" : (a1 < a2) ? s1 : s2;
        Console.WriteLine(ans);
    }
}
