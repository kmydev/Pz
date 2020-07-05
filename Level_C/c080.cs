using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int y = int.Parse(arr[1]);
        int m = int.Parse(Console.ReadLine().Trim());
        
        List<int> toPushButtonList = new List<int>();
        for (int i = 0; i < m; i++)
        {
            int ii = i%n+1;
            toPushButtonList.Add(ii);
        }

        arr = Console.ReadLine().Trim().Split(' ');
        List<int> pushedButtonList = new List<int>();
        for (int i = 0; i < m; i++)
        {
            pushedButtonList.Add(int.Parse(arr[i]));
        }

        int pts = 0;
        int ng = 0;
        for (int i = 0; i < m && ng < y; i++)
        {
            if (toPushButtonList[i] == pushedButtonList[i])
            {
                pts += 1000;
            }
            else
            {
                ng++;
            }
        }
        
        if (ng == y)
        {
            pts = -1;
        }
        
        Console.WriteLine(pts);
    }
}
