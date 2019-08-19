using System;

public class Pz{
    public static void Main(){
        string ymd = Console.ReadLine().Trim();
        ymd = ymd.Replace(' ', '/');
        Console.WriteLine(ymd);
    }
}
