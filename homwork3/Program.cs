// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*int Palindrom (int number)
{   
    int a = number / 10000;
    int b = (number/1000)%10;
    int c = (number /10)%10;
    int d = number % 10;
    if (a == d || b == c)
    {
        Console.WriteLine($"{number} является палиндромом");
        return number;
    }
    else
    {
        Console.WriteLine($"{number} Не является палиндромом");
        return number;
    }
}
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = Palindrom (number);*/

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void NumberN (int A)
{
    Console.WriteLine($"Куб чисел от 1 до {A}: ");
    for (int i = 1; i <= A; i++)
    {
        Console.Write($"{i*i*i},");
    }
}
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
NumberN(Number);*/

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*void FindDistance(double x1, double y1, double z1, double x2, double y2, double z2 )
{
    double sumx = x2-x1;
    double sumy = y2-y1;
    double sumz = z2-z1;
    double distance = Math.Round(Math.Sqrt(sumx*sumx + sumy*sumy + sumz*sumz), 2);
    Console.WriteLine($"Расстояние между точками {distance}");
}
Console.WriteLine("Coordinat of x1");
double pointx1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Coordinat of y1");
double pointy1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Coordinat of z1");
double pointz1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Coordinat of x2");
double pointx2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Coordinat of y2");
double pointy2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Coordinat of z2");
double pointz2 = Convert.ToDouble(Console.ReadLine());
FindDistance(pointx1,pointy1,pointz1,pointx2,pointy2,pointz2);*/