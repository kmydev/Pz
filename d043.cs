using System;

public class Pz{
    public static void Main(){
        int n = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine((n >= 71) ? "rainy" : (n <= 30) ? "sunny" : "cloudy");
    }
}
