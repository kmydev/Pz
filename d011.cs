using System;
using System.Text;

public class Pz{
    public static void Main(){
        string s = Console.ReadLine().Trim();
        char a = 'A';
        char c = s[0];
        Console.WriteLine((int)c - (int)a + 1);
    }
}
