/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

int[,] array = new int[4, 4];

FillArray(array);
PrintArray(array);

Console.WriteLine("среднее арифметическое элементов в каждом столбце");

void Average (int[,] matrix)
{
    double a = 0; 

    for (int k = 0; k< matrix.GetLength(1); k++)
    {
        double av = 0; 
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            av = matrix [l, k] + av;
            
        }
    a = av / matrix.GetLength(1);
    Console.Write(a + " ; ");
    }
   
}

Average(array);
