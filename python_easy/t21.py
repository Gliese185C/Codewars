



fib = [0,1]
for i in range(1,7+1):
    fib.append(fib[i]+fib[i-1])

print(4*sum(fib))