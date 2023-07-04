//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


// Console.WriteLine("Input first integer: ");
// int number_1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Input second integer: ");
// int number_2 = int.Parse(Console.ReadLine());

// int number_3 = number_2 * number_2;

// if (number_1 == number_3)
// {
//     Console.WriteLine("The first number is the square of the second number");
// }
// else
// {
//     Console.WriteLine("The first number is NOT the square of the second number");
// }



// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

using System.Diagnostics;
using System.Globalization;

Console.Write("Input integer from 1 to 7 incl: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case (1):
        Console.WriteLine("Monday");
        break;
    case (2):
        Console.WriteLine("Tuesday");
        break;
    case (3):
        Console.WriteLine("Wednesday");
        break;
    case (4):
        Console.WriteLine("Thursday");
        break;
    case (5):
        Console.WriteLine("Friday");
        break;
    case (6):
        Console.WriteLine("Saturday");
        break;
    case (7):
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("you integer is not correct");
    break;
}


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.Write("Input 3-digit integer: ")
// double number = double.Parse(Console.ReadLine());

// if (99 < number && number < 1000):
// {
//     double number_1 = number % 10;
//     Console.WriteLine($"last digit of number is: {number_1}");
// }
// else
// {
//     Console.WriteLine("Input integer is not in needed range");
// }


