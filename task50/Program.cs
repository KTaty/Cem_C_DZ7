// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GenerateArray()
{
    int rowNumber = new Random().Next(2, 5);
    int colNumber = new Random().Next(2, 5);
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(0, 100);
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
            Console.Write("{0: 0}", arrayToPrint[i, j]);
            if (j < arrayToPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}
void CheckAndPrintElement(int numberElement, int[,] array)
{
    int row = array.GetLength(0);
    int cow = array.GetLength(1);
    if (numberElement < row * cow)
    {
        int rowElementa= numberElement/row;
        int cowElementa= numberElement%row;
        Console.WriteLine($"элемента с номером {numberElement} это {array[rowElementa,cowElementa]}");
    }
    else{
        Console.WriteLine("элемента с таким номером не существует");
    }
}

Console.Clear();
int[,] array = GenerateArray();
Console.WriteLine("Задан двухмерный массив");
print2DArray(array);
Console.Write("Введите номер элемента (начиная с 0): ");
int numberElement = Convert.ToInt32(Console.ReadLine());
CheckAndPrintElement(numberElement,array);
