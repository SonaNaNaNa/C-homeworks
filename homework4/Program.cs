//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*int NumberDegre(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result*a;
    }
    return result;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number1 = Convert.ToInt32(Console.ReadLine());
int newNumberDegre = NumberDegre (number, number1);
Console.WriteLine($"{number} в степени {number1}-> {newNumberDegre}");*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int NumberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a /10;
        index++;
    }
    return index;
}
int NumberLengteSum(int n, int c )
{
    int sum = 0;
    for (int i = 1; i <= c; i++)
    {
        sum = sum + n % 10;
        n = (n - n % 10)/10;
    }
    return sum;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = NumberLength(number);
int SumNumber = NumberLengteSum(number, count);
Console.WriteLine ($"Сумма цифр числа {number} -> {SumNumber}");*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*int[] CreatArray(int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray [i] = new Random().Next(0, 1000);
    }
return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив ->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
int size = 8;
int[] myArray = CreatArray(size);
ShowArray(myArray);*/