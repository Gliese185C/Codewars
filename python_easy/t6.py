'''

Complete the function which converts a binary number (given as a string) to a decimal number.

'''


bin_to_decimal = lambda inp: sum([int(inp[len(inp)-i-1]) * 2**i for i in range(len(inp))])


'best practics'

'''

def bin_to_decimal(inp):
    return int(inp, 2)
    
bin_to_decimal = lambda inp: int(inp,2)

def bin_to_decimal(inp):
    return int(inp, base=2)
    
    
from functools import partial

bin_to_decimal = partial(int, base=2)


'''