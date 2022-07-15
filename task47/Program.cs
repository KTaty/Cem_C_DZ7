//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] GenerateArray(int rowNumber, int colNumber){
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = (new Random().NextDouble())*100;
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
void print2DArray(double[,] arrayToPrint)
{
    Console.Write(" \t");
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
            Console.Write("{0: 00.000}",arrayToPrint[i, j]);
            if (j < arrayToPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
                
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк:");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int colNumber= Convert.ToInt32(Console.ReadLine());
double[,] array = GenerateArray(rowNumber , colNumber);
print2DArray(array);
