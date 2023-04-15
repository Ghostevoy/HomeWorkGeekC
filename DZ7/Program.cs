// методы для создания массива
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GetRandomMatrixDouble(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(rand.Next(min, max + 1) + rand.NextDouble(), 2);
        }
    }

    return array;
}

int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }

    return array;
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

}

void PrintMatrixDouble(double[,] matrix)
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


StartDZ47();
Console.ReadKey();

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void StartDZ47()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");

    double[,] matrix = GetRandomMatrixDouble(rows, columns, 10, 99);
    PrintMatrixDouble(matrix);
}



//Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет

StartDZ50();
Console.ReadKey();

void StartDZ50()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");

    int[,] matrix = GetRandomMatrix(rows, columns, -100, 100);
    PrintMatrix(matrix);
    Console.Write("Какое число необходимо найти?-> ");
    int searchValue = int.Parse(Console.ReadLine());
    (int, int, bool) indexNum = SearchIndex(matrix, searchValue);
    if (indexNum.Item3)
    {
        Console.WriteLine($"Искомое значение находится в строке {indexNum.Item1 + 1}, столбец {indexNum.Item2 + 1}");
    }
    else
    {
        Console.WriteLine("Искомого значения нет в таблице.");
    }

}

(int, int, bool) SearchIndex(int[,] matrix, int yourNumber)
{
    bool numFound = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == yourNumber)
            {
                numFound = true;
                return (i, j, numFound);
                break;

            }

        }

    }
    return (0, 0, numFound);
}



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

StartDZ52();

void StartDZ52()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");

    int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
    PrintMatrix(matrix);
    Console.Write("Средние значения столбцов равны " + string.Join(' ', averageColunms(matrix)));
}

double[] averageColunms(int[,] matrix)
{
    double[] sumColumns = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumColumns[j] += matrix[i, j];
        }

    }

    for (int k = 0; k < sumColumns.Length; k++)
    {
        sumColumns[k] /= matrix.GetLength(0);
    }

    return sumColumns;
}
