// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

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

bool CheckTwoMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    if (matrixOne.GetLength(0) != matrixTwo.GetLength(1))
    {
        return false;
    }
    return true;
}

int[,] MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    return resultMatrix;
}

// int[,] array2DOne = new int[,] { { 2, 4 }, { 3, 2 } };
// int[,] array2DTwo = new int[,] { { 3, 4 }, { 3, 3 } };

int[,] array2DOne = CreateMatrixRndInt(2, 2, -10, 10);
int[,] array2DTwo = CreateMatrixRndInt(2, 2, -10, 10);

if (CheckTwoMatrix(array2DOne, array2DTwo) != true) Console.WriteLine("Нельзя перемножить");
else
{
    int[,] array2DResult = MultiplyMatrix(array2DOne, array2DTwo);

    Console.WriteLine("Первая матрица");
    PrintMatrix(array2DOne);

    Console.WriteLine();
    Console.WriteLine("Вторая матрица");
    PrintMatrix(array2DTwo);

    Console.WriteLine();
    Console.WriteLine("Произведение двух матриц");
    PrintMatrix(array2DResult);
}