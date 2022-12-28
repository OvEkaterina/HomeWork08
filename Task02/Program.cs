// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void MinSumRow(int[,] array)
{
    int[] summArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ = (array[i, j] + summ);
            summArray[i] = summ;
        }

        Console.WriteLine($"Сумма строки {i + 1} = {summ}");
    }
    int min = summArray[0];
    int index = 0;
    for (int i = 0; i < summArray.Length; i++)
    {
        if (summArray[i]< min)
        {
            min =summArray[i];
            index =i;
        } 
        
                
    }
  
    Console.WriteLine($"Минимальная сумма в строке {index + 1} = {min}");

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

int[,] array = FillArray(4, 4, 1, 10);
PrintArr(array);
Console.WriteLine();
MinSumRow(array);