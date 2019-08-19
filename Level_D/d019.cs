using System;

public class Pz{
    public static void Main(){
        string[] arr = Console.ReadLine().Trim().Split(' ');
        string s = arr[0];
        int n = int.Parse(arr[1]);

        Console.WriteLine(s[n-1]);
    }
}
