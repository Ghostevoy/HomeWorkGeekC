// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int inputText(string message)
{
    System.Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int pow(int numA, int numB)
{
    int pow = 1;
    for (int i = 1; i<=numB; i++)
    {
        pow *= numA;
    }
    return pow;
}

System.Console.WriteLine(pow(inputText("число А "), inputText("число В ")));
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int sumNums(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number%10;
        number/=10;
    }
    return sum;
}
System.Console.WriteLine(sumNums(inputText("Ввели число для расчеты суммы чисел.")));
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array(int minArr, int maxArr, int length = 8)
{
    int[] mass = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        mass[i]= rand.Next(minArr,maxArr);
    }
    return mass;
}

System.Console.WriteLine("[" + string.Join(", ", array(inputText("введи минимальное значение "), inputText("Введи максимальное значение массива "))) + "]");