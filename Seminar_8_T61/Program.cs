/* Задача 61: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного Треугольника */

Console.Write("Input rows number: ");
int row = int.Parse(Console.ReadLine());


int[,] triangle = new int[row,row];
const int cellWitgh = 2;

void FillTriangle()
{
    
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void printTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i, j], cellWitgh}");
        }
        Console.WriteLine();
    }
}

void Magic()
{
    int col = cellWitgh * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] % 2 != 0) Console.Write($"{triangle[i, j],cellWitgh}");
            //if (triangle[i, j] != 0) Console.WriteLine("*");
            col += cellWitgh * 2;
        }
        
        col = cellWitgh * row - cellWitgh * (i + 1);
        Console.WriteLine();
    }
}

Console.WriteLine();

FillTriangle();
//printTriangle();
//Console.ReadLine();
Magic();
