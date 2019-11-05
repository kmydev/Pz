using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int k = int.Parse(arr[1]);
        int p = int.Parse(arr[2]);
        arr = Console.ReadLine().Trim().Split(' ');
        Array.Sort(arr);
        StringBuilder sb = new StringBuilder();
        for (int i = k * (p - 1); i < k * p && i < arr.Length; i++)
        {
            sb.Append(arr[i] + Environment.NewLine);
        }
        Console.WriteLine(sb.ToString().Trim());
    }
}
