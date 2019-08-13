using System;
using System.Text;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        int n = int.Parse(line);
        StringBuilder sb = new StringBuilder();
        
        for (int i = 1; i <= 9; i++)
        {
            sb.Append(i * n);
            sb.Append(" ");
        }

        System.Console.WriteLine(sb.ToString().Trim());
    }
}
