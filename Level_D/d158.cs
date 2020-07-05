using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Pz{
    public static void Main(){
        int moist = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine((moist >= 40 && moist <= 60) ? "OK" : "NG");
    }
}
