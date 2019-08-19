using System;

public class Pz{
    public static void Main(){
        int t = int.Parse(Console.ReadLine().Trim());
        int cnt = 0;
        int blocking = 0;

        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine().Trim();
            //Console.WriteLine("Loop:{0} blocking:{1} name:{2}", i, blocking, s);
            if (blocking <= 0 && "melon" == s)
            {
                cnt++;
                blocking = 10;
            }
            else
            {
                blocking--;
            }
        }
        
        Console.WriteLine(cnt);
    }
}
