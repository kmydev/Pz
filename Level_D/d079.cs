using System;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        bool isOk = false;
        char c1 = s[0];
        for (int i = 1; i < s.Length; i++)
        {
            if (c1 != s[i])
            {
                isOk = true;
                break;
            }
        }
        Console.WriteLine((isOk) ? "OK" : "NG");
    }
}
