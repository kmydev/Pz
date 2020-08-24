# coding: utf-8
if __name__=='__main__':
    arr = raw_input().strip().split(' ')
    m = int(arr[0])
    n = int(arr[1])
    print '%d %d' % (m / n, m % n)
