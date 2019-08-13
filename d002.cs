using System;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        string[] arr = line.Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        string ans = (a == b) ? "eq" : (a > b) ? a.ToString() : b.ToString();
        System.Console.WriteLine(ans);
    }
}
