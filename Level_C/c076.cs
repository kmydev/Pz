using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int x = int.Parse(arr[0]);
        int y = int.Parse(arr[1]);
        int z = int.Parse(arr[2]);
        int n = int.Parse(Console.ReadLine().Trim());

        int sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            arr = Console.ReadLine().Trim().Split(' ');
            int fromH = int.Parse(arr[0]);
            int toH = int.Parse(arr[1]);
            sum += getsum(fromH, toH, x, y, z);
        }
        
        Console.WriteLine(sum);
    }
    
    private static int getsum(int fromh, int toh, int x, int y, int z)
    {
        int ret = 0;
        
        List<int> hourList = new List<int>();
        for (int i = 0; i < 24; i++)
        {
            hourList.Add(0);
        }

        for (int i = fromh; i < toh; i++)
        {
            hourList[i] = 1;
        }
        
        for (int i = 0; i < 24; i++)
        {
            if (hourList[i] != 0)
            {
                if (i >= 9 && i < 17)
                {
                    ret += x;
                }
                else if (i >= 17 && i < 22)
                {
                    ret += y;
                }
                else
                {
                    ret += z;
                }
            }
        }
        
        return ret;
    }
}
