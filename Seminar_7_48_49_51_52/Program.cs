// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

//int m = 5;
//int n = 4;

/*int[,] fillAmnMatrix (int width, int height)
{
    int[,] new_array = new int[width, height];

    for (int widthCount = 0; widthCount < width; widthCount++)
    {
        for (int heightCount = 0; heightCount < height; heightCount++)
            {
                new_array[widthCount, heightCount] = heightCount + widthCount; 
            }
    }

    return new_array;
}

void printAmnMatrix (int[,] input_matrix)
{

    for (int widthCount = 0; widthCount < input_matrix.GetLength(0); widthCount++)
    {
        for (int heightCount = 0; heightCount < input_matrix.GetLength(1); heightCount++)
            {
                Console.Write(input_matrix[widthCount, heightCount] + " ");
            }
        System.Console.WriteLine();
    }
}

printAmnMatrix(fillAmnMatrix(m, n));
*/


/* Задача 49: Задайте двумерный массив.
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4


int m = 4;
int n = 4;

int[,] RandomMatrix (int width, int height)
{
    int[,] new_array = new int[width, height];

    for (int widthCount = 0; widthCount < width; widthCount++)
    {
        for (int heightCount = 0; heightCount < height; heightCount++)
            {
                new_array[widthCount, heightCount] = new Random().Next(0, 10);
            }
    }

    return new_array;
}

void modifyMatrix (int[,] input_matrix)
{
//    int[,] new_array = new int[input_matrix.GetLength(0), input_matrix.GetLength(1)];

    for (int widthCount = 0; widthCount < input_matrix.GetLength(0); widthCount++)
    {
        for (int heightCount = 0; heightCount < input_matrix.GetLength(1); heightCount++)
            {
                if ((widthCount > 0 && (widthCount % 2 != 0)) &&
                    (heightCount > 0 && (heightCount % 2 != 0)))
                {
                    input_matrix[widthCount, heightCount] = input_matrix[widthCount, heightCount] * input_matrix[widthCount, heightCount];
                }
            }
    }
}

void printMatrix (int[,] input_matrix)
{

    for (int widthCount = 0; widthCount < input_matrix.GetLength(0); widthCount++)
    {
        for (int heightCount = 0; heightCount < input_matrix.GetLength(1); heightCount++)
            {
                Console.Write(input_matrix[widthCount, heightCount] + " ");
            }
        System.Console.WriteLine();
    }
}

int[,] new_matrix = RandomMatrix(m, n);

System.Console.WriteLine("New Matrix:");
printMatrix(new_matrix);

System.Console.WriteLine();

System.Console.WriteLine("Modified Matrix:");
modifyMatrix(new_matrix);
printMatrix(new_matrix);
*/


/* Задача 51: Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12

*/

int[,] RandomMatrix (int width, int height)
{
    int[,] new_array = new int[width, height];

    for (int widthCount = 0; widthCount < width; widthCount++)
    {
        for (int heightCount = 0; heightCount < height; heightCount++)
            {
                new_array[widthCount, heightCount] = new Random().Next(0, 10);
            }
    }
    return new_array;
}

void printMatrix (int[,] input_matrix)
{
    for (int widthCount = 0; widthCount < input_matrix.GetLength(0); widthCount++)
    {
        for (int heightCount = 0; heightCount < input_matrix.GetLength(1); heightCount++)
            {
                Console.Write(input_matrix[widthCount, heightCount] + " ");
            }
            System.Console.WriteLine();
    }
}

void printDiagonalMatrixSum (int[,] input_matrix)
{
    int result = 0;
    for (int widthCount = 0; widthCount < input_matrix.GetLength(0); widthCount++)
    {
        for (int heightCount = 0; heightCount < input_matrix.GetLength(1); heightCount++)
            {
                if (widthCount == heightCount)
                {
                    result = result + input_matrix[widthCount, heightCount];
                }
            }
    }
    System.Console.WriteLine($"main Diagonal sum = {result}");
}

int[,] new_matrix = RandomMatrix(4, 4);

System.Console.WriteLine("New random matrix:");
printMatrix(new_matrix);

printDiagonalMatrixSum(new_matrix);


// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

//int[,] array = new int [5,5];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//         array[i,j] = new Random().Next(1,5);
//         Console.Write(array[i,j] + " ");
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int sum = 0;
//    double avResult = 0.0;
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        sum = sum + array[j,i];
//    }
//    avResult = (double) sum / array.GetLength(1);
//    Console.WriteLine($"column average {i} is {avResult}");
//}