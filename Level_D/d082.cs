using System;

public class Pz{
    public static void Main(){
        string a = Console.ReadLine().Trim();
        string last_a = a.Substring(a.Length-1, 1);
        string b = Console.ReadLine().Trim();
        string top_b = b.Substring(0, 1);
        string last_b = b.Substring(b.Length-1, 1);
        bool isOk = ((last_b != "n") && (last_a == top_b) && (a.Length >= 2) && (a.Length <= 20) && (b.Length >= 2) && (b.Length <= 20));
        Console.WriteLine((isOk) ? "OK" : "NG");
    }
}
