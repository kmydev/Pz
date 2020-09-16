# coding: utf-8

if __name__=="__main__":
    s = raw_input().strip()
    f = False
    for i in range(10):
        t = str(i)
        if len(s.replace(t, '')) <= 2:
            f = True
            break
        
    if f==True:
        print('NG')
    else:
        print('OK')
