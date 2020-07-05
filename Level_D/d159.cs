using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        int maxlen = 0;
        for (int i = 0; i < 3; i++)
        {
            int sl = Console.ReadLine().Trim().Length;
            maxlen = (sl > maxlen) ? sl : maxlen;
        }

        Console.WriteLine(maxlen);
    }
}
