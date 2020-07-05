using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        List<int> cardList = new List<int>(m);
        for (int i = 0; i < m; i++)
        {
            cardList.Add(new int());
        }
        
        int ans = -1;
        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine().Trim());
            cardList[value-1]++;
            if (isFill(cardList) == true)
            {
                ans = i;
                break;
            }
        }

        if (ans == -1)
        {
            Console.WriteLine("unlucky");
        }
        else
        {
            Console.WriteLine(ans+1);
        }
    }
    
    private static bool isFill(List<int> anslist)
    {
        for (int i = 0; i < anslist.Count; i++)
        {
            if (anslist[i] == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
