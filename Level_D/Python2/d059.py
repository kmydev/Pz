# coding: utf-8

if __name__=="__main__":
    arr = raw_input().strip().split(' ')
    if arr[0]=='J' and arr[1]=='J':
        print('J Q')
    else:
        print('{0} {1}'.format(arr[0], arr[1]))
