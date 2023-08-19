// 1 1 2 3 5 8 13 21 34 55 : fibonacci

int[] fib = new int[10];
fib[0] = 1;
fib[1] = 1;


for (int i = 2; i < 10; i++)
{
    fib[i] = fib[i - 1] + fib[i - 2];
}

foreach (var i in fib)
{
    
    Console.Write(i + " ");
}
