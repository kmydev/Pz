# coding: utf-8

if __name__=="__main__":
    arr = raw_input().strip().split(' ')
    s = ""
    for i in range(int(arr[0])):
        s+="A"
    for i in range(int(arr[1])):
        s+="B"
    for i in range(int(arr[2])):
        s+="A"
    print(s)
