using System;
using System.Text;

public class Pz{
    public static void Main(){
        var n = int.Parse(Console.ReadLine().Trim());
        var s = Console.ReadLine().Trim();
        StringBuilder sb = new StringBuilder();
        for (int i = n-1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        sb.Append(s.Substring(n, s.Length-n));

        Console.WriteLine(sb.ToString());
    }
}
