using System;

public class Pz{
    public static void Main(){
        string[] arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int d = int.Parse(arr[1]);
        int e = int.Parse(arr[2]);
        Console.WriteLine((d * e >= n) ? "OK" : "NG");
    }
}
