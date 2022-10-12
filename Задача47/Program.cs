/* Задайте двумерный массив размером m*n, заполненный случайными
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


Console.Clear();
 
Console.Write("Введите число столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число строк: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);


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

