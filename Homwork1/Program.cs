//Задача 2 написать программу, которая на вход принимает два числа и выдает,какое число больше а какое меньше//
/*Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"{num1} > {num2}");
}
else
{
Console.WriteLine($"{num2} > {num1}");
}*/

//Задача 4 максимальное из 3 чисел//
Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number ");
int num3 = Convert.ToInt32(Console.ReadLine());
max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine($"{max}");