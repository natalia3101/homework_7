/*
 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }

    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void GetColumnAverage(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
                
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = matrix[i, j] + average;
            
        }
        average = average / matrix.GetLength(1);
        Console.Write(Math.Round(average, 1) + "; ");
    }
       
}

int rows = GetNumber("Enter the number of rows");
int columns = GetNumber("Enter the number of columns");
int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
GetColumnAverage(matrix);