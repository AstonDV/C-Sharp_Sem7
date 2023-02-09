// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:         
//     1 4 7 2                     Сумма элементов главной
//     5 9 2 3                     диагонали: 1+9+2 = 12
//     8 4 2 4                     


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

int SumEvenIndexArray(int[,] inputArray)
{
    int sum = 0;
    int j = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        if (j < inputArray.GetLength(1)) sum += inputArray[i, j];
        j++;
    }
    return sum;
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
    int sumEvenIndex = SumEvenIndexArray(array);
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов главной диагонали равна {sumEvenIndex}");
}

Main();