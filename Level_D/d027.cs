using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        int sum = 0;
        
        for (int i = n; i > 0; i--)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }
}
