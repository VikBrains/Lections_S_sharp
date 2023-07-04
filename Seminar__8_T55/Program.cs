/* Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

int[,] array = new int [5,5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         array[i,j] = new Random().Next(1,10);
         Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

int [,] ChangeRows (int[,] inputArray) 

{
    int [,] OutputMatrix = new int [inputArray.GetLength(0), inputArray.GetLength(1)];
    if (inputArray.GetLength(0) == inputArray.GetLength(1))
    {
        

        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                OutputMatrix[j,i] = inputArray[i,j];
            }
        }
    }
    else
    {
        System.Console.WriteLine("operation impossible, matrix isn't a square");
    }
    return OutputMatrix;
}

void printMatrix (int[,] input_array) { 
    System.Console.WriteLine();  
    System.Console.Write("Your flipped array is:");
    for (int column = 0; column < input_array.GetLength(0); column++){
        System.Console.WriteLine();
        for (int row = 0; row < input_array.GetLength(1); row++){
            System.Console.Write(input_array[column, row] + " ");
        }
    }
}

printMatrix (ChangeRows(array));
