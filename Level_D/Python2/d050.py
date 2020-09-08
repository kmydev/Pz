# coding: utf-8

if __name__=="__main__":
    arr = raw_input().strip().split(' ')
    n = 0
    for s in arr:
        n1 = int(s)
        if n1 > 5:
            n += 5
        else:
            n += n1

    print(n)
