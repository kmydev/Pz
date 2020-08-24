# coding: utf-8
if __name__=='__main__':
    max = 1
    min = 99
    for i in range(5):
        n = int(raw_input().strip())
        if n < min:
            min = n
        if n > max:
            max = n
    print '%d\n%d' % (max, min)
