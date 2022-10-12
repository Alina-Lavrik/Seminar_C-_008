// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

int[,] array = GetArray(5, 4, 0, 9);
PrintArray(array);
Console.WriteLine("");
PrintArray(ArrayWhithoutMin (array, GetMin(array)));

int [] GetMin(int [,] array)
{
    int min = array[0,0];
    int [] res = new int [] {0,0};
    for (int i=0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {
                min = array[i,j];
                res[0] = i;
                res[1] = j;
            }
        }
    }
    return res;
}

int[,] ArrayWhithoutMin(int [,] array, int[] RowColMin)
{
    int[,] result = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i!=RowColMin[0] && j!=RowColMin[1])
            {
                int x = 0;
                int y = 0;
                if (i>RowColMin[0])
                {
                    x = -1;
                }
                if (j > RowColMin[1])
                {
                    y = -1;
                }
                result [i+x, j+y] = array[i,j];
            }
        }
    }
    return result;
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


