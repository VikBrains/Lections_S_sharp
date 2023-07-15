/*Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Input integer: ");
int number = int.Parse(Console.ReadLine());

int FillNatural(int n)
{
    if (n == 0) return 1;
    int temp = 1 + FillNatural(n-1);
    Console.Write(n + ", ");
    return temp;
}

FillNatural(number);*/

/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

/* Console.Write("Input integer: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Input integer: ");
int numN = int.Parse(Console.ReadLine());

int FillNatural(int M, int N)   
{
    if (M - 1 == N) return N;
    int temp = 1 + FillNatural(M, N-1);
    Console.Write(N + " ");
    return temp;
}

FillNatural(numM, numN);*/

/*string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(1, 5));*/

/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9

Console.Write("Input integer: ");
int number = int.Parse(Console.ReadLine());

int SumRecIntegers(int number)
{
    if (number == 0) return 0;
    int temp = number % 10 + SumRecIntegers(number / 10);
    return temp;
}

Console.WriteLine(SumRecIntegers(number));*/

