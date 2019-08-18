using System;

public class Pz{
    public static void Main(){
        string[] arr = Console.ReadLine().Trim().Split(' ');
        string s = string.Format("Hi, {0} {1}", ((arr[1] == "M") ? "Mr." : "Ms."), arr[0]);
        
        Console.WriteLine(s);
    }
}
