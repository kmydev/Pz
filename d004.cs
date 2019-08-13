using System;
using System.Text;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        int n = int.Parse(line);

        StringBuilder sb = new StringBuilder();
        sb.Append("Hello ");

        for (int i = 0; i < n; i++)
        {
            sb.Append(Console.ReadLine().Trim());
            if (i < n - 1) sb.Append(",");
        }
        sb.Append(".");

        System.Console.WriteLine(sb.ToString().Trim());
    }
}
