using System;

public class Pz{
    public static void Main(){
        var arr = Console.ReadLine().Trim().Split(' ');
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int len = (a.ToString().Length > b.ToString().Length) ? a.ToString().Length : b.ToString().Length;
        string fmt = string.Format("D{0}", len);
        int sum = 0;
        for (int i = 10; i <= 1000; i*=10)
        {
            int aa = a % i; int bb = b % i;
            sum += ((aa + bb) % i);
            a -= aa; b -= bb;
        }
        Console.WriteLine(sum.ToString(fmt));
    }
}
