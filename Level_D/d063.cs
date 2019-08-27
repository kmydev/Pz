using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int[] tn = new int[5];
        for (int i = 0; i < 5; i++)
        {
            tn[i] = int.Parse(arr[i]);
        }

        int a = int.Parse(Console.ReadLine().Trim());
        int p = 1;
        for (int i = 0; i < 5; i++)
        {
            if (a < tn[i])
            {
                break;
            }
            
            p++;
        }
        
        Console.WriteLine(p);
    }
}
