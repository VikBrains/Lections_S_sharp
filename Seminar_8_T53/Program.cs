

// int[,] array = new int [5,5];

Print(array);
Console.WriteLine();

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

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            OutputMatrix[i,j] = inputArray[i,j];
        }
    }

    // Меняем элементы последней строки на элементы 1-ой
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        OutputMatrix[inputArray.GetLength(0) - 1, i] = inputArray[0,i];
    }

    // Меняем элементы первой строки на элементы последней
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        OutputMatrix[0,i] = inputArray[OutputMatrix.GetLength(0) - 1,i];
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
