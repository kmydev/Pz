# coding: utf-8
import math


def isHit(oy, spd, theta, dist, height, dia):
    low = height - (dia / 2.0)
    top = height + (dia / 2.0)
    rad = math.radians(theta)
    v1 = oy + dist * math.tan(rad)
    v2 = (9.8 * dist * dist) / (2.0 * spd * spd * math.cos(rad) * math.cos(rad))
    y = v1 - v2
    if y >= low and y <= top:
        return y

    return -1.0
    
    
if __name__=="__main__":
    arr = raw_input().strip().split(' ')
    oy = int(arr[0])
    spd = int(arr[1])
    theta = int(arr[2])
    arr = raw_input().strip().split(' ')
    dist = int(arr[0])
    height = int(arr[1])
    dia = int(arr[2])
    
    y = isHit(oy, spd, theta, dist, height, dia)
    if y >= 0.0:
        print('Hit {0:.1f}'.format(abs(height - y)))
    else:
        print('Miss')
