using System;
using System.Text;

public class Pz{
    public static void Main(){
        StringBuilder sb = new StringBuilder();
        string[] arr = Console.ReadLine().Trim().Split(' ');
        for (int i = 0; i < 3; i++)
        {
            int n = int.Parse(arr[i]);
            for (int j = 0; j < n; j++)
            {
                sb.Append((i % 2 == 0) ? "A" : "B");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
