/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();
 
Console.Write("Введите число строк: ");
int m = Math.Abs(int.Parse(Console.ReadLine()!));
Console.Write("Введите число столбцов: ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Average(array);


void FillArray(double[,] array)
{
    Random generator = new Random();
 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = generator.Next(0,10);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
/*         Console.Write("["); */
        for (int j = 0; j < array.GetLength(1); j++)
        {
/*             if (j < array.GetLength(1) - 1) */
                Console.Write($"|{array[i, j]}|");
/*             else
                Console.Write(array[i, j]); */
        }
/*         Console.Write("]"); */
        Console.WriteLine();
    }
}

void Average(double[,] array)
{  
    double averageToColumn = 0;  
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0; 
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
            if (j == array.GetLength(0) - 1)
            {
                averageToColumn = sum / array.GetLength(0);
                Console.Write($"{Math.Round(averageToColumn, 2)}; ");  
            }

        }
    }
}

