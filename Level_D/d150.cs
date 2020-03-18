using System;
using System.Text;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        int x = int.Parse(Console.ReadLine().Trim());
        int y = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine("{0}", ((x < y) ? (y - x).ToString() : "Thank you"));
    }
}
