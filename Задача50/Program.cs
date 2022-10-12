/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет */

Console.Clear();
 
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс строки: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int y = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);


if (((x < array.GetLength(0)) & (y < array.GetLength(1))))
{
    PrintArray(array);
    Console.WriteLine(ReturnToPosition(array, x, y));
}
else
    Console.WriteLine("Элемента не существует");


void FillArray(int[,] array)
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

void PrintArray(int[,] array)
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

int ReturnToPosition(int[,] array, int x, int y)
{
    int num = 0;
    if ((x < array.GetLength(0)) & (y < array.GetLength(1)))
    {
        for (int i = 0; i <= x; i++)
        {
            for (int j = 0; j <= y; j++)
            {
                num = array[i, j];
            }
        }
    }
    return num;
}