import math

s = 'DDDDPDDCCCDDPDCCPCDCDDPCPCCDDCD'


def DPC_sequence(s):
    divide = []
    n_divide = []
    rela = []

    for i, item in enumerate(s):
        if item == 'D':
            divide.append(i + 1)
        elif item == 'P':
            rela.append(i + 1)
        else:
            n_divide.append(i + 1)

    for n in range(1,10 ** 9):
        state = True
        for item in divide:
            if n % item != 0:
                state = False
                break
        for item in n_divide:
            if n % item == 0:
                state = False
                break
        for item in rela:
            if math.gcd(n, item) == 0:
                state = False
                break
        if state:
            return n
        else:
            continue
    return -1

print(DPC_sequence(s))