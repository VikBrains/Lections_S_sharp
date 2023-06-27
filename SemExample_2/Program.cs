// See https://aka.ms/new-console-template for more information

//double[] array = new double[50];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = Math.Round((new Random().NextDouble()* new Random().Next(0,10)), 2);
//    Console.Write(array[i] + " ");
//}

//double min = array[0];
//for (int i = 1; i < array.Length; i++)
//{
//    if (array[i] < min)
//    {
//        min = array[i];
//    }
//}
//Console.WriteLine($"minimum is {min}");

//     
int[] array = new int[10] {1, 4, 7, 98, 32, 4, 12, -9, 4, 55 };

int[] reverseArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    reverseArray[i] = array[(array.Length - 1) - i];
}

for (int i = 0; i < reverseArray.Length; i++)
{
    Console.Write(reverseArray[i] + " ");
}

//

//int[] array = new int[6] {1, 4,  32, -9, 4, 55 };
//for (int j = 0; j < array.Langth / 2; j++)
//{
//    int temp = array[j];
//    arrayj[j] = array[(array.Length - 1) - j];
//    array[(array.Length -1) - j] = temp;
//}

//for (int j = 0; j < array.Length; j++)
//{
//    Console.Write(array[j] + " ");
//}

//

