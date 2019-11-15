using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < n; i++)
        {
            arr = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int pt = a - b * 5;
            if (pt < 0) pt = 0;
            if (pt >= m)
            {
                sb.Append((i + 1).ToString());
                sb.Append(Environment.NewLine);
            }
        }
        
        Console.Write(sb.ToString());
    }
}
