// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив         Новый массив будет выглядеть
// выглядел вот так:                   вот так:
// 1 4 7 2                             1 4 49 2
// 5 9 2 3                             5 81 2 9
// 8 4 2 4                             64 4 4 4


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void UpdateArray(int[,] firstArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i += 2)
    {
        for (int j = 0; j < firstArray.GetLength(1); j += 2)
        {
            firstArray[i, j] *= firstArray[i, j];
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void Main()
{
    Console.Clear();
    Console.Write("Введите кол-во строк: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int col = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    int[,] array = GetArray(row, col, 0, 10);
    PrintArray(array);
    UpdateArray(array);
    Console.WriteLine();
    PrintArray(array);
}

Main();