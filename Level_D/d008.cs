using System;
using System.Text;

public class Pz{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        int n = int.Parse(line);

        Console.WriteLine("{0}", ((n % 2 == 0) ? "even" : "odd"));
    }
}
