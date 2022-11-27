//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreatArray (int size)
{
    int [] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100,1000);
    }
    return newArray;
}
int  FindEvenNumber(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}     
void ShowArray(int[] array)
{
    Console.Write("Получившийся массив ->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatArray(a);
int findeven = FindEvenNumber(myArray);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в Массиве {findeven}");*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreatArray (int size)
{
    int [] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(1,11);
    }
    return newArray;
}
void ShowArray(int[] array)
{
    Console.Write("Получившийся массив ->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
int SumUnevenIndex(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i= i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatArray(a);
int result = SumUnevenIndex(myArray);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {result}");*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*double[] CreatArray(int size)
{
    double [] newArray = new double [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
    return newArray;
}
double DifMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
       if (max < array[i]) max = array[i];
       if (min > array[i]) min = array[i];
    }
    double result = max - min;
    return result;
}
void ShowArray(double[] array)
{
    Console.Write("Получившийся массив ->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
double [] myArray = CreatArray(a);
double dif = DifMaxMin(myArray);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом -> {dif}");*/
