# coding: utf-8

if __name__=='__main__':
    n = int(raw_input().strip())

    if n >= 71:
        print('rainy')
    elif n >= 31:
        print('cloudy')
    else:
        print('sunny')
