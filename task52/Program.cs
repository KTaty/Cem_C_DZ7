// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GenerateArray()
{
    int rowNumber = new Random().Next(2, 5);
    int colNumber = new Random().Next(2, 5);
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-10, 10);
        }
    }
    return result;
}
void printGreen(int number)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{number}\t");
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (var i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printGreen(i);
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printGreen(i);
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            if (arrayToPrint[i, j] > 0)
            {
                Console.Write($" {arrayToPrint[i, j]}");
            }
            else
            {
                Console.Write(arrayToPrint[i, j]);
            }
            if (j < arrayToPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}
int[] GetColumn(int[,] array, int numberColumn)
{
    int length = array.GetLength(0);
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = array[i, numberColumn];
    }
    return result;
}
double Mean1DAray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    double result = (double) sum / array.Length;
    return result;
}
void PrintMeanColumn(int[,] array)
{
    int length = array.GetLength(1);
    int[] column = new int[array.GetLength(0)];
    double meanColumn;
    for (int i = 0; i < length; i++)
    {
        column = GetColumn(array, i);
        meanColumn = Mean1DAray(column);
        Console.Write($"среднеарифметическое {i} столбца = ");
        Console.WriteLine("{0: 0.00}",meanColumn);
    }
}

Console.Clear();
int[,] array = GenerateArray();
Console.WriteLine("Задан двухмерный массив");
print2DArray(array);
PrintMeanColumn(array);