/* **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7 */

int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
Console.WriteLine("");

if (array.GetLength(0) == array.GetLength(1))
{
    int[,] NewArray = ChangeArrayRowColumns(array);
    PrintArray(NewArray);
}
else{
    Console.WriteLine("No possible");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[,] ChangeArray(int[,] array)
{
    int[,] res = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                res[i, j] = array[array.GetLength(0) - 1, j];
            }
            else if (i == array.GetLongLength(0) - 1)
            {
                res[i, j] = array[0, j];
            }
            else
            {
                res[i, j] = array[i, j];
            }
        }
        
    }
    return res;
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

int[,] ChangeArrayRowColumns(int [,] array)
{
    int[,] res = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res [j,i] = array[i,j];
        }
    }
    return res;
}

