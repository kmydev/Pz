using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        Console.WriteLine((s[1]==s[2]&&s[1]==s[3]) ? "Yes" : "No");
    }
}
