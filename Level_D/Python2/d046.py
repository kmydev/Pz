# coding: utf-8

if __name__=="__main__":
    n = 0
    arr = raw_input().strip().split(' ')

    for s in arr:
        if n < int(s):
            n = int(s)

    print(n)
