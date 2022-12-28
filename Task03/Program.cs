// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        int [,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
 
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (var j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
 
                for (int k = 0; k < matrixA.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
 
        return matrixC;
    }

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[,] array1 = FillArray(2, 2, 1, 10);
int[,] array2 = FillArray(2, 2, 1, 10);
int [,] array3 = MatrixMultiplication(array1, array2);
Console.WriteLine("Матрица 1:");
PrintArr(array1);
Console.WriteLine("Матрица 2:");
PrintArr(array2);
Console.WriteLine("Результирующая матрица будет:");
PrintArr(array3);
