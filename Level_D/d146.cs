using System;
using System.Collections.Generic;
using System.Text;


public class Paiza{
    public static void Main(){
        var line = Console.ReadLine().Trim().Replace("a", "").Replace("i", "").Replace("u", "").Replace("e", "").Replace("o", "");
        Console.WriteLine(line);
    }
}
