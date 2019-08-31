using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int t = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        string ans = (t >= 25 && m <= 40) ? "No" : (t >= 25 || m <= 40) ? "Yes" : "No";
        Console.WriteLine(ans);
    }
}
