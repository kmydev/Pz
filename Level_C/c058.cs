using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int n = int.Parse(arr[0]);
        string t = arr[1];
        string s = arr[2];

        int times = 0;
        while(t != s)
        {
            s = string.Format("{0}{1}", s.Substring(1, s.Length - 1), s.Substring(0, 1));
            times++;
            //Console.WriteLine("{0}:{1}:{2}", times, t, s);
        }

        Console.WriteLine(times);
    }
}
