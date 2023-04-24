int EnterNum(string message)
{
    Console.Write(message);
    int number;
    while (true)
    {
        bool isNumber = int.TryParse(Console.ReadLine(), out number);

        if (!isNumber)
        {
            Console.WriteLine("Необходимо ввести число");
        }
        else break;
    }

    return number;
}


//Задача 64: Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

HomeWork64();

void HomeWork64()
{
    Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. \n" +
"N = 5 -> '5, 4, 3, 2, 1' \nN = 8 -> '8, 7, 6, 5, 4, 3, 2, 1'");
    int numM = EnterNum("Введи число М ");
    int numN = EnterNum("Введи число N ");
    bool isDecrease = numM > numN;
    WriteNum(numM, numN, isDecrease);
    System.Console.WriteLine();
}

void WriteNum(int number1, int number2, bool comparingNum)
{
    if (comparingNum && number1 >= number2)
    {
        Console.Write($"{number1}, ");
        WriteNum(number1 - 1, number2, comparingNum);
    }
    else if (comparingNum == false && number2 >= number1)
    {
        Console.Write($"{number1}, ");
        WriteNum(number1 + 1, number2, comparingNum);
    }
}


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

HomeWork66();

void HomeWork66()
{
    System.Console.WriteLine();
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N." +
"\n M = 1; N = 15-> 120 \n M = 4; N = 8. -> 30");
    int numM = EnterNum("Введи число М ");
    int numN = EnterNum("Введи число N ");
    bool isDecrease = numM > numN;
    int sum;
    if (isDecrease) sum = sumNumbers(numN, numM);
    else sum = sumNumbers(numM, numN);
    Console.WriteLine(sum);


}

int sumNumbers(int number1, int number2, int sum = 0)
{
    return (number1 <= number2) ? sum = number1 + sumNumbers(number1 + 1, number2, sum) : 0;

}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

HomeWork68();



int Numburg(int numA = 3, int numB = 2)
    {
    if (numA == 0) return numB + 1;
    else if (numA > 0 && numB == 0) return Numburg(numA - 1, 1);
    else return Numburg(numA - 1, Numburg(numA, numB - 1));
}
void HomeWork68()
{
    System.Console.WriteLine();
    System.Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. \n" +
"m = 2, n = 3->A(m, n) = 9 \n m = 3, n = 2->A(m, n) = 29");
    while (true)
    {
        int numberM = EnterNum("Введи 1-е число ");
        int numberN = EnterNum("Введите 2-е число ");
        if (numberM >= 0 && numberN >= 0) 
        {
            Console.WriteLine(Numburg(numberM, numberN));
            break;
        }
        else Console.WriteLine(" Необходимо указать неотрицательные значения. ");
    }
}