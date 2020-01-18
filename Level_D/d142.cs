using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int x = int.Parse(arr[1]);
        int y = int.Parse(arr[2]);
        int valves = ((n + (x - 1)) / x) * y;
        Console.WriteLine(valves);
    }
}
