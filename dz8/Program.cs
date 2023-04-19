
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
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


//Урок 8. Двумерные массивы. Продолжение
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

HomeWork54();

void HomeWork54()
{
    int[,] matrix = GetRandomMatrix(SetNumber("row"), SetNumber("columns"), 0, 100);
    PrintMatrix(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        MinMax(matrix, i, 0);
    }
    Console.WriteLine();
    PrintMatrix(matrix);
    Console.ReadKey();
}

void MinMax(int[,] matrix, int row, int column)
{
    int tmp = matrix[row, column];
    for (int j = column; j < matrix.GetLength(1); j++)
    {
        if (tmp < matrix[row, j])
        {
            tmp = matrix[row, j];
            matrix[row, j] = matrix[row, column];
            matrix[row, column] = tmp;
        }
        if (j == matrix.GetLength(1) - 1 && column < matrix.GetLength(1) - 1)
        {
            MinMax(matrix, row, column + 1);
        }

    }

}





//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

HomeWork56();

void HomeWork56()
{
    Console.Clear();
    int[,] matrix = GetRandomMatrix(SetNumber("row"), SetNumber("columns"), 0, 100);
    PrintMatrix(matrix);

    (int, int) result = CheckSumMatr(matrix);
    Console.WriteLine($"Минимальная сумма элементов {result.Item1} рассчитывается в строке {result.Item2}");

    Console.ReadKey();
}

(int, int) CheckSumMatr(int[,] matrix)
{
    int sum = 0;
    int minSum = int.MaxValue;
    int minSumIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }
        Console.WriteLine(sum);
        if (minSum > sum)
        {
            minSum = sum;
            minSumIndex = i;

        }
        sum = 0;

    }
    return (minSum, minSumIndex + 1);
}






//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

HomeWork58();

void HomeWork58()
{
    Console.Clear();
    int[,] FirstMatrix = GetRandomMatrix(SetNumber("row"), SetNumber("columns"), 0, 10);
    PrintMatrix(FirstMatrix);
    Console.WriteLine();
    int[,] SecondtMatrix = GetRandomMatrix(SetNumber("row"), SetNumber("columns"), 0, 10);
    PrintMatrix(SecondtMatrix);
    Console.WriteLine();
    PrintMatrix(multiplication(FirstMatrix, SecondtMatrix));
    Console.ReadKey();


}

int[,] multiplication(int[,] MatrixA, int[,] MatrixB)
{
    int[,] MultiMatrix = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];

    if (MatrixA.GetLength(1) != MatrixB.GetLength(0))
    {
        Console.WriteLine("Перемножить данные матрицы не получится");
    }
    else
    {

        for (int i = 0; i < MatrixA.GetLength(0); i++)
        {
            for (int j = 0; j < MatrixB.GetLength(1); j++)
            {
                for (int k = 0; k < MatrixA.GetLength(0); k++)
                {
                    MultiMatrix[i, j] += MatrixA[i, k] * MatrixB[k, j];
                }
            }
        }
    }
    return MultiMatrix;
}






//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

HomeWork60();

void HomeWork60()
{
    Console.Clear();
    int[,,] matrix3D = Get3DMatrix(SetNumber("rows"), SetNumber("columns"), SetNumber("depths"));
    Print3DMatrix(matrix3D);


}

int[] NumbersForRandom()
{
    int[] Numbers = new int[90];
    for (int i = 0; i < 90; i++)
    {
        Numbers[i] = i+10;
    }
    return Numbers;
}

void RemoveNum(ref int[] array, int index)
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < index; i++)
    {
        newArray[i] = array[i];
    }
    for (int j = index + 1; j < array.Length; j++)
    {
        newArray[j - 1] = array[j];
    }
    array = newArray;
}


int[,,] Get3DMatrix(int rows, int columns, int depths)
{
    int[,,] array = new int[rows, columns, depths];
    var rand = new Random();
    int[] NumArray = NumbersForRandom();


    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                int randomIndex = rand.Next(0, NumArray.Length);
                array[i, j, k] = NumArray[randomIndex];
                RemoveNum(ref NumArray, randomIndex);
            }
        }
    }

    return array;

}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i,j,k]} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


//Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

HomeWork62();

void HomeWork62()
{
    int row = SetNumber("row");
    int column = SetNumber("column");
    int[,] matrix = FillMatrix(row, column);
    PrintMatrix(matrix);
    


}

int[,] FillMatrix(int rows, int columns)
{
    int count = 1;
    int[,] matrix = new int[rows, columns];
    int firstRows = 0; 
    int lastRows = rows - 1;
    int firstColumn = 0;
    int lastColumn = columns - 1;

    while (lastColumn>=firstColumn && lastRows>=firstRows) 
    {
        for (int i = firstColumn; i <= lastColumn; i++)
        {
            matrix[firstRows, i] = count;
            count++;
        }
        firstRows++;
        for (int j = firstRows; j <= lastRows; j++)
        {
            matrix[j, lastColumn] = count;
            count++;
        }
        lastColumn--;
        for (int k = lastColumn; k >= firstColumn; k--)
        {
            matrix[lastRows, k] = count;
            count++;    
        }
        lastRows--;
        
        for (int m = lastRows; m >= firstRows; m--)
        {
            matrix[m, firstColumn] = count;
            count++;    

        }
        firstColumn++;

    }
    return matrix;
}