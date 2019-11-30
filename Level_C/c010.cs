using System;
using System.Text;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int r = int.Parse(arr[2]);

        int n = int.Parse(Console.ReadLine().Trim());
        
        string [] ans = new string[n];
        for (int i = 0; i < n; i++)
        {
            arr = Console.ReadLine().Trim().Split(' ');
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);
            ans[i] = isSilent(a, b, r, x, y);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(ans[i]);            
        }
    }
    
    private static string isSilent(int a, int b, int r, int x, int y)
    {
        int r2 = ((x - a) * (x - a)) + ((y - b) * (y - b));
        if (r2 >= r * r)
        {
            return "silent";
        }
        
        return "noisy";
    }
}
