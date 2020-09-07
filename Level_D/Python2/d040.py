# coding: utf-8

if __name__=='__main__':
    n = 0
    for i in range(7):
        t = int(raw_input().strip())
        if t <= 30:
            n += 1
    
    print(n)
