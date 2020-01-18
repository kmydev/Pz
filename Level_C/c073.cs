using System;

public class Pz{
    public static void Main(){
        int l = int.Parse(Console.ReadLine().Trim());
        var arr = Console.ReadLine().Trim().Split(' ');
        int u = int.Parse(arr[0]);
        int a = int.Parse(arr[1]);
        int b = int.Parse(arr[2]);
        int v = int.Parse(Console.ReadLine().Trim());
        
        int rtime = 0;
        rtime = l * u;
        rtime += ((l - 1) / a) * b;

        //Console.WriteLine(rtime);

        int ttime = 0;
        ttime = l * v;

        //Console.WriteLine(ttime);

        string ans = (rtime == ttime) ? "DRAW" : (rtime < ttime) ? "USAGI" : "KAME";
        Console.WriteLine(ans);
    }
}
