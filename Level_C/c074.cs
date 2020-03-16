using System;
using System.Text;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int h = int.Parse(arr[0]);
        int w = int.Parse(arr[1]);
        int x = int.Parse(arr[2]);
        
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < h; i++)
        {
            sb.Append(Console.ReadLine().Trim());
        }
        
        if (sb.Length % x != 0)
        {
            int nn = ((sb.Length + (x - 1)) / x) * x;
            int nnn = nn - sb.Length;
            for (int i = 0; i < nnn; i++)
            {
                sb.Append(" ");    
            }
        }

        for (int i = 0; i < sb.Length; i += x)
        {
            Console.WriteLine(sb.ToString().Substring(i, x).Trim());
        }
    }
}
