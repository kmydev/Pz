# coding: utf-8

import datetime

if __name__=="__main__":
    n = int(raw_input().strip())
    names = []
    minutes = []
    for i in range(n):
        arr = raw_input().strip().split(' ')
        names.append(arr[0])
        minutes.append(int(arr[1]))
    
    dt = datetime.datetime(2020, 1, 1, hour=10, minute=0)
    m = 0
    brk = 50
    times = []
    for i in range(n):
        dt1 = dt + datetime.timedelta(minutes=m)
        dt2 = dt1 + datetime.timedelta(minutes=minutes[i])
        #print(i)
        times.append('{0} - {1} {2}'.format(dt1.strftime('%H:%M'), dt2.strftime('%H:%M'), names[i]))
        m += minutes[i] + 10
        if i < n - 1 and m + minutes[i+1] > 120:
            m += brk
            brk = 0

    for s in times:
        print(s)
