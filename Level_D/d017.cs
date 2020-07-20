using System;
using System.Text;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        int max_n = 0;
        int min_n = 100;
        for (int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            if (n > max_n) max_n = n;
            if (n < min_n) min_n = n;
        }
        Console.WriteLine(max_n);
        Console.WriteLine(min_n);
    }
}
