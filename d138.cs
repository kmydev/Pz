using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int w = int.Parse(arr[0]);
        int h = int.Parse(arr[1]);
        
        string ans = "";
        for (int i = 0; i < h; i++)
        {
            ans += Console.ReadLine().Trim().Substring(0, w) + Environment.NewLine;
        }
        Console.WriteLine(ans);
    }
}
