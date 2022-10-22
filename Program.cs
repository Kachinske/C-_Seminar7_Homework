// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] ArrayTask74 = GetArrayWithDoubleNumbers(3, 4, -100, 100);
PrintDoubleArray(ArrayTask74);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

Console.WriteLine("Enter row number:");
int Row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter column number:");
int Column = int.Parse(Console.ReadLine()!);
int[,] ArrayTask50 = GetArrayWithIntNumbers(4, 4, 0, 9);
PrintIntArray(ArrayTask50);
Console.WriteLine();
ShowElementIn2dArray(ArrayTask50, Row, Column);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] ArrayTask52 = GetArrayWithIntNumbers(3, 3, 0, 9);
PrintIntArray(ArrayTask52);
ShowAverageByColumn(ArrayTask52);

//--------------------------------Methods Block------------------------------------------

int[,] GetArrayWithIntNumbers(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double[,] GetArrayWithDoubleNumbers(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(minValue, maxValue), 1);
        }
    }
    return result;
}

void PrintIntArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintDoubleArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ShowElementIn2dArray(int[,] array, int rowNumber, int columnNumber)
{
    if (rowNumber <= array.GetLength(0)
        && rowNumber > 0
        && columnNumber <= array.GetLength(1)
        && columnNumber > 0)
    { Console.WriteLine($"На пересечении {rowNumber} строки и {columnNumber} столбца находится число: {array[rowNumber - 1, columnNumber - 1]}"); }
    else { Console.WriteLine($"В данном массиве кол-во строк: {array.GetLength(0)}, количество столбцов: {array.GetLength(1)}, вы вышли за пределы массива"); }
}

void ShowAverageByColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];

        }
        average = Math.Round(sum / array.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое в столбце {j + 1}: {average}");
    }
}
