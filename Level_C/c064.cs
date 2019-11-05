using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int m = int.Parse(arr[0]);
        int n = int.Parse(arr[1]);
        int[] c = new int[m];
        for (int i = 0; i < m; i++)
        {
            c[i] = int.Parse(Console.ReadLine().Trim());
        }
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            var arr2 = Console.ReadLine().Trim().Split(' ');
            for (int j = 0; j < m; j++)
            {
                int cal = c[j] * int.Parse(arr2[j]) / 100;
                a[i] += cal;
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
