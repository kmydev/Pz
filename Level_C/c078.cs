using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int c1 = int.Parse(arr[1]);
        int c2 = int.Parse(arr[2]);
        
        int pl = 0;
        int stock = 0;
        for (int i = 0; i < n; i++)
        {
            int p = int.Parse(Console.ReadLine().Trim());
            
            if (i == n - 1)
            {
                pl += p * stock;
                stock = 0;
                break;
            }
            
            if (p <= c1)
            {
                stock++;
                pl -= p;
            }
            else if (p >= c2 && stock > 0)
            {
                pl += p * stock;
                stock = 0;
            }
        }
        
        Console.WriteLine(pl);
    }
}
