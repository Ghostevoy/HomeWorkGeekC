//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("введите число А: ");
string strNumA = Console.ReadLine();
int numA = Convert.ToInt32(strNumA);

Console.Write("введите число B: ");
string strNumB = Console.ReadLine();
int numB = Convert.ToInt32(strNumB);

if(numA > numB)
{
    Console.Write($"Число {numA} больше числа {numB}");
}
else if(numB == numA)
{
    Console.Write($"Указанные числа равны");
}
else
{
    Console.Write($"Число {numB} больше числа {numA}");
}