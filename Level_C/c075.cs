using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Split(' ');
        int n = int.Parse(arr[0]);
        int m = int.Parse(arr[1]);
        int p = 0;
        
        for (int i = 0; i < m; i++)
        {
            int unchin = int.Parse(Console.ReadLine());
            if (p >= unchin)
            {
                p -= unchin;
            }
            else
            {
                n -= unchin;
                p += (int)((double)unchin * 0.1);
            }
            
            Console.WriteLine("{0} {1}", n, p);
        }
    }
}
