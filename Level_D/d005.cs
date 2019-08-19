using System;
using System.Text;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        string[] arr = line.Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            sb.Append(m + n * i);
            if (i < 9) sb.Append(" ");
        }

        Console.WriteLine(sb.ToString().Trim());
    }
}
