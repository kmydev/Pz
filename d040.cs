using System;

public class Pz{
    public static void Main(){
        int cnt = 0;

        for (int i = 0; i < 7; i++)
        {
            int t = int.Parse(Console.ReadLine().Trim());
            if (t <= 30) cnt++;
        }

        Console.WriteLine(cnt);
    }
}
