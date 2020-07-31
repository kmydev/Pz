using System;
using System.Text;
using System.Collections.Generic;

public class LogInfo {
    public int ip1 { get; set; }
    public int ip2 { get; set; }
    public int ip3 { get; set; }
    public int ip4 { get; set; }
    public string logtime { get; set; }
    public string uri { get; set; }
    public override string ToString()
    {
        return string.Format("{0}.{1}.{2}.{3} {4} {5}", ip1, ip2, ip3, ip4, logtime, uri);
    }
}

public class Pz{
    public static void Main(){
        var ip = Console.ReadLine().Trim();
        int n = int.Parse(Console.ReadLine().Trim());
        
        List<LogInfo> loginfolist = new List<LogInfo>();
        for (int i = 0; i < n; i++)
        {
            var logstr = Console.ReadLine().Trim();
            LogInfo loginfo = getloginfo(logstr);
            if (loginfo != null) loginfolist.Add(loginfo);
        }
        
        var iparr = ip.Split('.');
        foreach (var loginfo in loginfolist)
        {
            if (isLog(iparr, loginfo))
            {
                Console.WriteLine(loginfo.ToString());
            }
        }
    }
    
    private static bool isLog(string[] iparr, LogInfo loginfo)
    {
        if (loginfo.ip1 != int.Parse(iparr[0])) return false;
        if (loginfo.ip2 != int.Parse(iparr[1])) return false;

        if (iparr[2] != "*")
        {
            if (iparr[2].StartsWith("["))
            {
                var s = iparr[2].Substring(1, iparr[2].IndexOf("]")-1);
                var sarr = s.Split('-');
                if (loginfo.ip3 < int.Parse(sarr[0]) || loginfo.ip3 > int.Parse(sarr[1])) return false;
            }
            else if (loginfo.ip3 != int.Parse(iparr[2])) return false;
        }

        if (iparr[3] != "*")
        {
            if (iparr[3].StartsWith("["))
            {
                var s = iparr[3].Substring(1, iparr[3].IndexOf("]")-1);
                var sarr = s.Split('-');
                if (loginfo.ip4 < int.Parse(sarr[0]) || loginfo.ip4 > int.Parse(sarr[1])) return false;
            }
            else if (loginfo.ip4 != int.Parse(iparr[3])) return false;
        }

        return true;
    }
    
    private static LogInfo getloginfo(string logstr)
    {
        LogInfo ret = new LogInfo();
        int n = logstr.IndexOf("-");
        var iparr = logstr.Substring(0, n).Trim().Split('.');
        ret.ip1 = int.Parse(iparr[0]);
        ret.ip2 = int.Parse(iparr[1]);
        ret.ip3 = int.Parse(iparr[2]);
        ret.ip4 = int.Parse(iparr[3]);
        var uriarr = logstr.Split('"');
        var uriarr2 = uriarr[1].Split(' ');
        ret.uri = uriarr2[1].Trim();
        var dtarr = logstr.Split('[');
        var dtarr2 = dtarr[1].Split(' ');
        ret.logtime = dtarr2[0].Trim();
        return ret;
    }
    
    /*

入力例1
192.168.186.70
3
192.168.110.238 - - [10/Jul/2013:18:40:43 +0900] "GET /top.html HTTP/1.1" 404 8922 "http://gi-no.jp" "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.116 Safari/537.36"
192.168.186.70 - - [10/Jul/2013:18:52:12 +0900] "GET /top.html HTTP/1.1" 404 3628 "http://facebook.com" "Mozilla/5.0 (Windows NT 5.1; rv:22.0) Gecko/20100101 Firefox/22.0"
192.168.105.56 - - [10/Jul/2013:20:13:52 +0900] "GET /top.html HTTP/1.1" 200 1863 "http://paiza.jp" "Mozilla/5.0 (iPad; CPU OS 6_0_1 like Mac OS X) AppleWebKit/536.26 (KHTML, like Gecko) Version/6.0 Mobile/10A523 Safari/8536.25"
出力例1
192.168.186.70 10/Jul/2013:18:52:12 /top.html
入力例2
192.168.[0-100].*
3
192.168.99.112 - - [10/Jul/2013:13:53:15 +0900] "GET /top.html HTTP/1.1" 404 1426 "http://facebook.com" "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.116 Safari/537.36"
192.168.81.20 - - [10/Jul/2013:15:06:33 +0900] "GET /hogehoge.html HTTP/1.1" 404 4374 "http://paiza.jp" "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_8_4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.116 Safari/537.36"
192.168.223.58 - - [10/Jul/2013:21:32:01 +0900] "GET /hoge.html HTTP/1.1" 304 6601 "http://paiza.jp" "Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:22.0) Gecko/20100101 Firefox/22.0"
出力例2
192.168.99.112 10/Jul/2013:13:53:15 /top.html
192.168.81.20 10/Jul/2013:15:06:33 /hogehoge.html
    */
}

