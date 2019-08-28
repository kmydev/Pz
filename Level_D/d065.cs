using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        if (s[0] == '2')
        {
            Console.WriteLine("ok");
        }
        else if (s[0] == '4')
        {
            Console.WriteLine("error");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
