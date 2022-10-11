/* **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2 */

int rows = 4;
int columns =4;

int[,] array = CreateArray(rows, columns);
FillArray(array, 1, 10);
PrintArray(array);
int[] array_null = new int[columns];
for (int i = 0; i < columns; i++)

{
    array_null[i] = array[0 , i];
    array[0 , i] = array[rows - 1, i];
    array[rows - 1, i] = array_null[i];
}
Console.WriteLine();
PrintArray(array);


int[,] FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows , columns];
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

