using System;
using System.Text;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        var arr = Console.ReadLine().Trim().Split(' ');
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(arr[i].Substring(0, 1));
        }
        Console.WriteLine(sb.ToString());
    }
}
