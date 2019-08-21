using System;

public class Pz{
    public static void Main(){

        int[] ans = new int[4];
        int d1 = int.Parse(Console.ReadLine().Trim());
        for (int i = 0; i < 4; i++)
        {
            int d2 = int.Parse(Console.ReadLine().Trim());
            ans[i] = d2 - d1;
            d1 = d2;
        }

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
}
