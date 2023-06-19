import math
s = 'DPDPCCD'
def DPC_sequence(s):
    divide = []
    n_divide = []
    rela = []
    state = True

    for i, item in enumerate(s):
        if item == 'D':
            divide.append(i + 1)
        elif item == 'P':
            rela.append(i + 1)
        else:
            n_divide.append(i + 1)

    lcm = math.lcm(*divide)
    n = lcm

    for item in rela:
        print(math.gcd(n,item))
        if math.gcd(n, item) > 1:
            state = False
            break

    if len(rela) == 0:
        state = False
    for item in n_divide:
        if n % item == 0:
            state = False
            break

    if state:
        return n
    else:
        return -1

print(DPC_sequence(s))