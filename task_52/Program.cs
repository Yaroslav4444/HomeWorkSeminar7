/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] generate2dArray(int height, int width, int minValue, int maxValue)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return twoDArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(data);
    Console.ResetColor();
}
void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine("]");
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[] getAverageElementsColumn(int[,] Array, int Value)
{
    double[] result = new double[Array.GetLength(1)];
    double Sum = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            Sum += Array[i, j];
        }
        double temp = Sum / Array.GetLength(0);
        result[j] = Math.Round(temp, Value);
        Sum = 0;
    }
    return result;
}

int[,] Array = generate2dArray(3, 4, 1, 10);
print2DArray(Array);
double[] generatedArray = getAverageElementsColumn(Array, 1);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
printArray(generatedArray);