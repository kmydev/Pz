using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        arr[1] = (arr[0] == "J" && arr[1] == "J") ? "Q" : arr[1];
        Console.WriteLine("{0} {1}", arr[0], arr[1]);
    }
}
