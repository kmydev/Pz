using System;

public class Pz{
    public static void Main(){
        string s = "ABCDEFGHIJ";
        var arr = Console.ReadLine().Trim().Split(' ');
        int[] s_n = new int[3];

        int p = 0;        
        for (int i = 0; i < 3; i++)
        {
            s_n[i] = int.Parse(arr[i]);
            Console.WriteLine(s.Substring(p, s_n[i]));
            p += s_n[i];
        }
    }
}
