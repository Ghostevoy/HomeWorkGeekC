// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// цвета 

ConsoleColor DefaultColor = Console.BackgroundColor;
ConsoleColor DefaultColor2 = Console.ForegroundColor;
ConsoleColor color1 = ConsoleColor.Gray;
ConsoleColor color2 = ConsoleColor.Blue;
ConsoleColor[] colors = { ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.Black };
// массив приветствия

char[,] hello = new char[7, 21]
{
    {'+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+',},
    {'+','-','+','-','+','-','-','-','+','-','+','+','+','-','+','+','+','-','-','-','+',},
    {'+','-','+','-','+','-','+','+','+','-','+','+','+','-','+','+','+','-','+','-','+',},
    {'+','-','-','-','+','-','-','-','+','-','+','+','+','-','+','+','+','-','+','-','+',},
    {'+','-','+','-','+','-','+','+','+','-','+','+','+','-','+','+','+','-','+','-','+',},
    {'+','-','+','-','+','-','-','-','+','-','-','-','+','-','-','-','+','-','-','-','+',},
    {'+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+',},

};


// исходные данные
bool mainMenuStatus = true;
int menuChoiсe = 0;
int countDZ34 = 0;
int size;
// Основа
helloStart();

while (true)
{
    if (mainMenuStatus)
    {
        menuChoiсe = menu();
        continue;
    }
    else
    {
        switch (menuChoiсe)
        {
            case 34:
                Loading();
                dz34();
                Console.SetCursorPosition(0, 4);
                Console.Write("Введи размер массива: ");
                size = int.Parse(Console.ReadLine());
                int[] arrayDz34 = GetArray(size);
                Console.SetCursorPosition(0, 6);
                Console.WriteLine(string.Join("; ", arrayDz34));
                countDZ34 = counter(arrayDz34);
                Console.WriteLine($"Четных чисел в массиве {countDZ34}");
                Console.WriteLine("");
                Console.WriteLine("Нажми клавишу для продолжения... ") ;
                Console.ReadKey();
                Console.Clear();
                countDZ34 = 0;
                mainMenuStatus = restart(); 
                continue;


                break;

            case 36:
                Loading();
                dz36();
                Console.SetCursorPosition(0, 5);
                Console.Write("Сколько должно быть элементов в массиве: ");
                size = int.Parse(Console.ReadLine());
                int[] arrayDz36 = GetArray(size);
                int sum = sumdz36(arrayDz36);
                Console.WriteLine(string.Join("; ", arrayDz36));
                Console.WriteLine($"Сумма нечетных элементов в массиве равна {sum}");
                mainMenuStatus = restart();
                continue;
                break;

            case 38:
                Loading();
                dz38();
                Console.SetCursorPosition(0, 4);
                Console.Write("Введите длину массива ");
                size = int.Parse(Console.ReadLine());
                double[] arrayDZ38 = GetArrayDoube(size);
                Console.WriteLine(string.Join("; ", arrayDZ38));
                double deltaMaxMin = sumMinMaxDZ38(arrayDZ38);
                Console.WriteLine($"Разница между максимальным и минимальным значением равна {deltaMaxMin}");
                mainMenuStatus= restart();
                continue;
                break;
            case 1: 
                Console.Clear();
                Console.WriteLine("Удачи!");
                Console.ReadKey();
                break;

            default:
                Console.WriteLine("Указанная задача не найдена. Повтори ввод.");
                mainMenuStatus = true;
                Console.ReadKey();
                continue;
                break;

        }
    }
    break;
}

// создание массива

int[] GetArray(int size, int minValue = 100, int maxValue = 1000)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }

    return result;
}
double[] GetArrayDoube (int size)
{
    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        result[i] = rnd.NextDouble() + rnd.Next(1, 1000);

    return result;
}

// Задание 34

void dz34()
{
    Console.Clear();
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.\n[345, 897, 568, 234] -> 2");
}

int counter(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countDZ34++;
        }
    }
    return countDZ34;
}


// Задание 36

void dz36()
{
    Console.Clear();
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\n[3, 7, 23, 12] -> 19\n[-4, -6, 89, 6]-> 0");
}
int sumdz36(int[] array)
{
    int sumDZ36 = 0;
    for (int i = 1; i < size; i += 2)
    {
        sumDZ36 += array[i];
    }
    return sumDZ36;
}

// Заданипе 38

void dz38()
{
    Console.Clear();
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\n[3 7 22 2 78] -> 76");
}
double sumMinMaxDZ38(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    for (int i = 0; i < size; i++)
    {
        if (maxNum > array[i])
        {
            maxNum = array[i];
        }

        if (minNum < array[i])
        {
            minNum = array[i];
        }

    }
    double result = maxNum - minNum;
    return result;

}

// стартовое меню
int menu()
{
    Console.Clear();
    Console.SetCursorPosition(0, 3);
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    System.Console.WriteLine("Набери 1 для выхода.");
    Console.SetCursorPosition(0, 0);
    Console.Write("Введи номер задачи, которую необходимо запустить ");
    int taskNum = 0;
    bool numCheck = int.TryParse(Console.ReadLine(), out taskNum);
    if (numCheck == true)
    {
        mainMenuStatus = false;
    }
    else
    {
        Console.WriteLine("Указанная задача не найдена. Попробуйте еще раз");
        Console.ReadKey();
    }
    return taskNum;
}

// выход из задачи или повтор. 

bool restart()
{
    Console.WriteLine("Нажми 1 чтобы выбрать другую задачу, или 2 - для повтора текущей: ");
    while (true)
    {
        try
        {
            int yourChoice = int.Parse(Console.ReadLine());
            if (yourChoice == 1)
            {
                return true;
                break;
            }
            else if (yourChoice == 2)
            {
                return false;
                break;

            }
            else
            {
                Console.WriteLine("Тут же довольно просто. 1 или 2. Попробуй еще раз.");
                continue;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Введена неверная команда. Попробуй еще раз!");
            continue;

        }

    }
}
// приветствие в консоли
void helloStart()
{
    for (int k = 1; k <= 5; k++)
    {
        switch (k)
        {
            case 1:
                PrintHello(ConsoleColor.Gray, colors[5]);
                Thread.Sleep(300);
                Console.Clear();
                break;
            case 2:
                PrintHello(ConsoleColor.Blue, colors[5]);
                Thread.Sleep(300);
                Console.Clear();
                break;
            case 3:
                PrintHello(ConsoleColor.Yellow, colors[5]);
                Thread.Sleep(300);
                Console.Clear();
                break;
            case 4:
                PrintHello(ConsoleColor.DarkBlue, colors[5]);
                Thread.Sleep(300);
                Console.Clear();
                break;
            case 5:
                PrintHello(ConsoleColor.White, colors[5]);
                Thread.Sleep(300);
                Console.Clear();
                break;


        }
    }
    

}

// отрисовка приветствия в массиве

void PrintHello(ConsoleColor color1, ConsoleColor color2)
{
    for (int i = 0; i < hello.GetLength(0); i++)
    {
        for (int j = 0; j < hello.GetLength(1); j++)
        {
            if (hello[i, j] == '-')
            {
                Console.BackgroundColor = color1;
                Console.ForegroundColor = color1;
                Console.Write(hello[i, j]);
                Console.BackgroundColor = DefaultColor;
                Console.ForegroundColor = DefaultColor2;

            }
            else
            {
                Console.BackgroundColor = color2;
                Console.ForegroundColor = color2;
                Console.Write(hello[i, j]);
                Console.BackgroundColor = DefaultColor;
                Console.ForegroundColor = DefaultColor2;
            }
        }

        Console.WriteLine();
    }

}

// Отрисовка загрузки

void DrowBar(int value, int maxValue, int loadInfo, ConsoleColor color = ConsoleColor.Gray)
{
    ConsoleColor DefaultColor = Console.BackgroundColor;
    string bar = "";
    for (int i = 0; i < value; i++)
    {
        bar += " ";

    }
    Console.SetCursorPosition(0, 0);
    Console.Write("|");
    Console.BackgroundColor = color;
    Console.Write(bar);
    Console.BackgroundColor = DefaultColor;

    bar = "";

    for (int i = value; i < maxValue - 1; i++)
    {
        bar += " ";
    }

    if (value == maxValue - 1)
    {
        Console.Write(bar + "| " + " ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(loadInfo + "%...ГОТОВО!");
        Console.ForegroundColor = DefaultColor;
        Thread.Sleep(150);
        Console.Clear();
    }
    else
    {
        Console.Write(bar + "| " + loadInfo + "%");
    }
    Console.BackgroundColor = DefaultColor;
    Console.ForegroundColor = DefaultColor2;
}

// запуск и параметры бара загрузки

void Loading()
{
    Console.Clear();
    int minBar = 0, maxBar = 20;

    for (int j = 0; j < maxBar; j++)
    {
        DrowBar(minBar, maxBar, (j + 1) * 5);
        Thread.Sleep(50);
        minBar++;
    }
}

