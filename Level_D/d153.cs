using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        var line = Console.ReadLine().Trim();
        var arr = line.Split(' ');
        List<int> nlist = new List<int>();
        foreach (var s in arr)
        {
            nlist.Add(int.Parse(s));
        }
        nlist.Sort();
        Console.WriteLine(nlist[1]);
    }
}
