/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7  */

Console.Write("\nInput rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[rows,columns];
Console.WriteLine($"Random array: ");
createArray(array);
printArray(array);
Console.WriteLine();

int[,] minElemPosition = new int[1, 2];
minElemPosition = FindMinElemPosition(array, minElemPosition);
Console.Write($"Min Element position: ");
printArray(minElemPosition);

int[,] FindMinElemPosition(int[,] array, int[,] position)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= temp)
            {
                position[0, 0] = i;
                position[0, 1] = j;
                temp = array[i, j];
            }
        }
    }
  Console.WriteLine($"Min value Element: {temp}");
  return position;
}

int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
DeleteLines(array, minElemPosition, arrayWithoutLines);
Console.WriteLine();
Console.WriteLine($"Sorted array:");
printArray(arrayWithoutLines);
Console.WriteLine();

void DeleteLines(int[,] array, int[,] minElemPosition, int[,] arrayWithoutLines)
{
    int k = 0, l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minElemPosition[0, 0] != i && minElemPosition[0, 1] != j)
            {
                arrayWithoutLines[k, l] = array[i, j];
                l++;
            }
        }
        l = 0;
        if (minElemPosition[0, 0] != i) k++;
    }
}

void createArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10,100);
        }
    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
