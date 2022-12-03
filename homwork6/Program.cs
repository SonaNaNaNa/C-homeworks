//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*void FindNumber(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        number++;
    }
}
Console.WriteLine($"Количествово элементов больше 0 -> {number}");
}
Console.Write("Введите элементы массива (через пробел): ");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
FindNumber(myArray);*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*void FindPoint(double k1, double b1, double k2, double b2)
{
double pointX =0;
double pointY =0;
if(k1==k2)
{
    Console.WriteLine("Прямые параллельные, не имеют точки пересечения");
}
else
{
    pointX = Math.Round((-b2 + b1)/(-k1 + k2),2);
    pointY = Math.Round((k1 * pointX + b1),2);
}
Console.WriteLine($"Точки пересечения прямых X -> {pointX} Y ->{pointY}");
}

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 FindPoint(k1,b1,k2,b2);*/
 
