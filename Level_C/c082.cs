using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int x = int.Parse(arr[0]);
        int y = int.Parse(arr[1]);
        int[] e = new int[x];
        int[] j = new int[x];
        int[] m = new int[x];
        int[] r = new int[x];
        
        for (int i = 0; i < x; i++)
        {
            arr = Console.ReadLine().Trim().Split(' ');
            e[i] = int.Parse(arr[0]);
            j[i] = int.Parse(arr[1]);
            m[i] = int.Parse(arr[2]);
        }
        int[] es = new int[x];
        Array.Copy(e, es, e.Length);
        Array.Sort(e);
        int[] js = new int[x];
        Array.Copy(j, js, j.Length);
        Array.Sort(j);
        int[] ms = new int[x];
        Array.Copy(m, ms, m.Length);
        Array.Sort(m);
        for (int i = 0; i < x; i++)
        {
            if (es[i] <= e[y-1]) r[i]++; 
            if (js[i] <= j[y-1]) r[i]++; 
            if (ms[i] <= m[y-1]) r[i]++; 
            Console.WriteLine(r[i]);
        }
    }
}
