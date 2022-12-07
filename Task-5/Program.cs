// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void SpiralMatrix(int[,] array, int length)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < length * length; e++)
    {
        int k = 0;

        do
        {
            array[i, j++] = value++;
        } 
        while (++k < length - 1);

        for (k = 0; k < length - 1; k++)
        {
            array[i++, j] = value++;
        }

        for (k = 0; k < length - 1; k++)
        {
            array[i, j--] = value++;
        }

        for (k = 0; k < length - 1; k++)
        {
            array[i--, j] = value++;
        }

        ++i;
        ++j;

        length = length < 2 ? 0 : length - 2;
    }
}

int len = 4;
int[,] array2D = new int[len, len];
SpiralMatrix(array2D, len);
Console.WriteLine();
PrintMatrix(array2D);