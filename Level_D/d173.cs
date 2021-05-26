using System;
using System.Text;

public class Pz{
    public static void Main(){
        var s = Console.ReadLine().Split(' ');
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length- 1; i >= 0; i--)
        {
            sb.AppendFormat("{0} ", s[i]);
        }
        Console.WriteLine(sb.ToString().Trim());
    }
}
