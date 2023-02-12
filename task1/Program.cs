//  Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] arr = Generate2DArray(4, 4);
Print2DArray(arr);
System.Console.WriteLine();
GetSortLine(arr);
Print2DArray(arr);

void GetSortLine(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}


int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


