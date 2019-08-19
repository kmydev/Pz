using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        string[] arr = s.Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        Console.WriteLine("{0} {1}", m / n, m % n);
    }
}
