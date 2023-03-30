// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.Write("Введи пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int saveNumber = number;
int paliNumber = 0;
while (number > 0)
{
    paliNumber = paliNumber*10 + number%10;
    number = number/10;
}

System.Console.WriteLine(paliNumber);

if (paliNumber == saveNumber)
{
    System.Console.WriteLine($"Число {saveNumber} является палиндромом");
}
else System.Console.WriteLine("Эт фигня какая та, а не палиндром");



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Введи координату Х точки А: ");
int xA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введи координату Y точки А: ");
int yA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введи координату Z точки А: ");
int zA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введи координату Х точки B: ");
int xB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введи координату Y точки B: ");
int yB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введи координату Z точки B: ");
int zB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xB-xA),2)+Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2));
System.Console.WriteLine($"Расстояние между точкой А и В составляет: {distance}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("До какого числа необходимо показать кубы?: ");
int kub = int.Parse(Console.ReadLine());
for (int i=1; i <= kub; i++)
{
    System.Console.Write(Math.Pow(i,3) + ", ");
}