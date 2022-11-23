/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

/*int SecondNumber(int num)
{
    int sot = num / 10;
    int result = sot % 10;
    return result;
}
int random = new Random().Next(100,1000);
int num1 = SecondNumber(random);
Console.WriteLine($"Вторая цфра {random} -> {num1}");*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/

/*bool Week (int day)
{
    if(day == 6 || day == 7)
    {
        return true;
    }
    {
        return false;
    }
}
Console.WriteLine ("input number of week");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Week (number);
Console.WriteLine(result);*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*int FindThrdNum (int number, int count)
{
    int result = 0;
    if (count < 3)
    {
        Console.Write("Третей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = count; i > 3; i--)
        {
            c = c*10;
        }
        result = (number/c)%10;
    }
    return result;
}
Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
Console.Write(FindThrdNum(number, count));*/