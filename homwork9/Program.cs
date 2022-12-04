/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
/*void ShowNumber(int N)
{
    if(N >= 1)
    {
        ShowNumber(N-1);
        Console.Write(" "+N);
    }
}
ShowNumber(8);*/


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*int ShowSum(int m, int n)
{
    if(m==n)
    return m;
    else
    {
        return ShowSum(m+1,n)+m;
    }
}
int sum  = ShowSum(4,8);
Console.Write(sum);*/


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
/*int FindAck(int m, int n)
{
    if(m==0)
    return n+1;
    else
    if(n==0 && m > 0)
    {
        return FindAck(m-1,1);
    }
    else 
    {
        return FindAck(m-1, FindAck(m, n-1));
    }
}
int sum = FindAck(2,3);
Console.WriteLine(sum);*/