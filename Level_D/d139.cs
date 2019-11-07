using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        var arr = Console.ReadLine().Trim().Split(' ');
        int g = 0;
        int p = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == "G")
            {
                g++;
            }
            else if (arr[i] == "P")
            {
                p++;
            }
        }
        
        Console.WriteLine((g == p) ? "Draw" : (g < p) ? "G" : "P");
    }
}
