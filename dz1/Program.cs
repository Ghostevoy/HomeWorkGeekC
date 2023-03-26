//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("введите число А: ");
string strNumA = Console.ReadLine();
int numA = Convert.ToInt32(strNumA);

Console.Write("введите число B: ");
string strNumB = Console.ReadLine();
int numB = Convert.ToInt32(strNumB);

if(numA > numB)
{
    Console.WriteLine($"Число {numA} больше числа {numB}");
}
else if(numB == numA)
{
    Console.WriteLine($"Указанные числа равны");
}
else
{
    Console.WriteLine($"Число {numB} больше числа {numA}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("введите число C: ");
string strNumC = Console.ReadLine();
int numC = Convert.ToInt32(strNumC);

if(numA>numB)
{
    if (numA>numC)
    {
        Console.WriteLine($"Самое большое число - A = {numA}");
    }
    else
    {
        Console.WriteLine($"Самое большое число - С = {numC}");
    }

}
else
{
    if (numB>numC)
    {
        Console.WriteLine($"Самое большое число - B = {numB}");
    }
    else
    {
        Console.WriteLine($"Самое большое число - С = {numC}");
    }
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

if(numA%2==0)
{
    Console.WriteLine($"Число А {numA} - четное");
}
else
{
    Console.WriteLine($"Число А {numA} - нечетное");
}

if(numB%2==0)
{
    Console.WriteLine($"Число B {numB} - четное");
}
else
{
    Console.WriteLine($"Число B {numB} - нечетное");
}
if(numC%2==0)
{
    Console.WriteLine($"Число C {numC} - четное");
}
else
{
    Console.WriteLine($"Число C {numC} - нечетное");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Забудь все, что ты вводил до этого момента и введи еще одно число, которое решит твою судьбу: ");
string strNumChet = Console.ReadLine();
int numChet = Convert.ToInt32(strNumChet);

int numberOfYourLife = 1;

if (numChet <=0)
{
    Console.WriteLine("Ах ты ж житрожопый. Вводить надо число больше 0! Твоя судьба мрачна...");

}
else 
{
    while(numberOfYourLife <= numChet)
    {
        if(numberOfYourLife%2==0)
        {
            Console.Write($"{numberOfYourLife}, ");
        }
        numberOfYourLife = numberOfYourLife+1;
    }
    Console.WriteLine("GoToVo. Твоя судьба светла, как свет в фонарике с батарейкой дюрасел");
}
