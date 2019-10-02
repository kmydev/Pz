using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int ans = int.Parse(arr[0]) * int.Parse(arr[1]);
        Console.WriteLine((ans >= 10000) ? "NG" : ans.ToString());
    }
}
