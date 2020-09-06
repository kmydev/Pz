using System;
using System.Text;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int r = int.Parse(arr[1]);
        
        int[] a_i = new int[n];
        int a_max = 0;
        List<string> slist = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            a_i[i] = int.Parse(Console.ReadLine().Trim());
            if (a_max < a_i[i]) a_max = a_i[i];
        }
        int maxlen = a_max / r;
        
        for (int i = 0; i < n; i++)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}:", i+1);
            for (int j = 1; j <= maxlen; j++)
            {
                if (a_i[i] >= r * j)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(".");
                }
            }
            slist.Add(sb.ToString());
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(slist[i]);
        }
    }
}
