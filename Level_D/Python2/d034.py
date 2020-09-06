# coding: utf-8

if __name__=="__main__":
    n = int(raw_input().strip())
    m = 21 % n
    if m == 0:
        m = n
    
    print(m)
