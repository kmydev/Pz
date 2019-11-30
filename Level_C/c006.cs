using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        int k = int.Parse(arr[2]);

        var carr = Console.ReadLine().Trim().Split(' ');
        double [] c = new double[n];
        for (int i = 0; i < n; i++)
        {
            c[i] = double.Parse(carr[i]);
        }

        int[] sum = new int[m];
        
        for (int j = 0; j < m; j++)
        {
            var marr = Console.ReadLine().Trim().Split(' ');
            double fsum = 0;
            for (int i = 0; i < n; i++)
            {
                fsum += (double.Parse(marr[i]) * c[i]);
            }
            sum[j] = (int)(fsum + 0.5);
        }
        
        Array.Sort(sum);
        
        for (int i = m - 1; i >= m - k; i--)
        {
            Console.WriteLine(sum[i]);            
        }
    }
}
