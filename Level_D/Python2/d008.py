# coding: utf-8

list1 = ['even', 'odd']

if (__name__=='__main__'):
    n = int(raw_input().strip())

    print list1[n % 2]
