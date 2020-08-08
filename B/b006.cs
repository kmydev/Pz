/*
10個のテストケースの内、全てのテストケースにおいて以下の条件を満たします。
以下の範囲で整数値
0 ≦ o_y[初期位置の高さ m] ≦ 100
1 ≦ [初速 m/s] ≦ 100
0 ≦ θ[度] ≦ 90
1 ≦ x[的までの距離 m] ≦ 100
0 ≦ y[的の高さ m] ≦ 100
1 ≦ a[的の直径 m] ≦ 100
重力加速度は小数値で以下のように定義します。
g[重力加速度 m/s^2] = 9.8
また、浮動小数の誤差が起こることを考慮しテストケースの矢の軌道は的の端0.05の範囲は通らないものとして入力されます。

入力例1
10 10 10
10 10 10
出力例1
Hit 3.3
入力例2
10 15 45
10 10 10
出力例2
Miss

*/

using System;

public class Hello{
    static double g = 9.8d;
    
    public static void Main(){
        string[] strArr = System.Console.ReadLine().Trim().Split(' ');
        int o_y = Int32.Parse(strArr[0]);
        int s = Int32.Parse(strArr[1]);
        int theta = Int32.Parse(strArr[2]);

        strArr = System.Console.ReadLine().Trim().Split(' ');
        int x = Int32.Parse(strArr[0]);
        int y = Int32.Parse(strArr[1]);
        int a = Int32.Parse(strArr[2]);

        double p = 0.0d;

        if (isHit((double)o_y, (double)s, (double)theta, (double)x, (double)y, (double)a, ref p))
        {
            Console.WriteLine("Hit {0:f1}", p);
        }
        else
        {
            Console.WriteLine("Miss");
        }
    }
    
    static bool isHit(double do_y, double ds, double dt, double dx, double dy, double da, ref double dp)
    {
        bool bRet = false;

        double radians = dt * (Math.PI / 180.0);
        double res_y =
            do_y
            +
            (Math.Tan(radians) * dx)
            -
            (
                (g * dx * dx) / (2.0d * ds * ds * Math.Cos(radians) * Math.Cos(radians))
            )
        ;

        if (res_y >= (dy - (da / 2.0d)) && res_y <= (dy + (da / 2.0d)))
        {
            bRet = true;
            dp = Math.Abs(dy - res_y);
        }

        return bRet;
    }
}
