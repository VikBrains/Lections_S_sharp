// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

//int[,] array = new int [m,n];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1), j++)
//    {
//
//    }
//}


// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int [5,5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         array[i,j] = new Random().Next(1,5);
         Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    double avResult = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[j,i];
    }
    avResult = (double) sum / array.GetLength(1);
    Console.WriteLine($"column average {i} is {avResult}");
}