/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)*/


//Random rnd = new Random();

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
            matrix[i,j] = new Random().Next(10,99);
        }
    }
}

        int[,] array = new int[7, 7];

        FillArray(array);
        PrintArray(array);

Console.WriteLine("Введите index1: ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите index2: ");
int index2 = Convert.ToInt32(Console.ReadLine());

void IndexElement (int[,] matrix, int rows, int columns)
{
    int min = 0;
      if (matrix.GetLength(0) > rows && matrix.GetLength(1) > columns)
        {
        min = matrix[rows, columns];
        Console.WriteLine(" - элемент массива с индексом [" + rows + ", " + columns + "] = " + min);
        }
    else Console.Write($"такого элемента в массиве нет.");
}
        
        IndexElement(array, index1, index2);