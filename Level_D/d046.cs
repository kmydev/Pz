using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int d1 = int.Parse(arr[0]);
        int d2 = int.Parse(arr[1]);
        int d3 = int.Parse(arr[2]);
        Console.WriteLine(max(d1, d2, d3));
    }
    
    public static int max(int a, int b, int c)
    {
        int ret = a;
        ret = (ret < b) ? b : ret;
        ret = (ret < c) ? c : ret;
        return ret;
    }
}
