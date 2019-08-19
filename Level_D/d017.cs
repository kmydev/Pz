using System;

public class Pz{
    public static void Main(){
        int max = 1;
        int min = 99;
        for (int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            max = (n > max) ? n : max;
            min = (n < min) ? n : min;
        }

        Console.WriteLine(max);
        Console.WriteLine(min);
    }
}
