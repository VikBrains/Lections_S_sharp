// написать рекурсивную функцию нахождения факториала

int GetFactorial(uint n)
{
    if (n == 0)
    {
        return 0;
    }

    int factorial = 1;
    for (int = 1; int <= n; int++)
    {
        factorial = factorial * int;
    }
    return factorial;
}



//

Console.Write("Input integer: ");
int number = int.Parse(Console.ReadLine());

int factorial = GetFactorial((uint) Math.Abs(number));
Console.WriteLine($"Factorial your integer is + {factorial}");