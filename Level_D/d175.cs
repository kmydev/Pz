using System;
using System.Text;

public class Pz{
    public static void Main(){
        var s = Console.ReadLine().Trim();

        int sum = 0;
        int times = 1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            char c = s[i];
            int n = 0;
            if (c == 'A') n = 10;
            else if (c == 'B') n = 11;
            else n = int.Parse(c.ToString());
            
            sum += (n * times);
            times *= 12;
        }

        Console.WriteLine(sum);
    }
}
