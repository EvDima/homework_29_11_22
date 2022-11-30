// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


void GetArray(int[,]  array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double MeanArray(int[,] numbers, double rows, int cols)
{
    double temp = 0;
    for (int i = 0; i < cols; i++)
    {
        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += numbers[i, j];
        }
        temp = sum / rows;
        Console.Write($"{temp}\t ");
    }
    return temp;
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] numbers = new int[rows, cols];
GetArray(numbers);
PrintArray(numbers);
MeanArray(numbers, rows, cols);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца");