//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
/*double[,] Creat2DRandomArray(int rows, int columns)
{
    double [,] newArray = new double [rows, columns];
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++) 
        {
            newArray[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
}
return newArray;
}
void Show2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine(); 
    }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Show2DArray(Creat2DRandomArray(rows, columns));*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int[,] Creat2DRandomArray(int rows, int columns)
{
    int [,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++) //столбцы
        {
            newArray[i,j] = new Random().Next(0, 101); 
        }
}
return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) //строки
    {
        for(int j = 0; j < array.GetLength(1); j++) //столбцы
        {
            Console.Write(array[i,j]+ " "); // печатает массив  " " пробел, к цифре прибавляет пробел потом пишет 2ую цифру
        }
        Console.WriteLine(); //чтобы печатала столбиком, после первой строки чтоб низ вклячить
    }


}
 void  FindIndex(int [,] array, int indI, int indJ)
 {

    if( indI> array.GetLength(0) ||  indJ > array.GetLength(1))
    {
    Console.WriteLine("Данный элемент не существует");
    }
    else
    Console.WriteLine($"На {indI} строке и {indJ} столбце элемент {array[indI-1,indJ-1]}");
 }
 Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки");
int indI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int indJ = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Creat2DRandomArray(rows, columns);
Show2DArray(myArray);
FindIndex(myArray, indI, indJ);*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*int[,] Creat2DRandomArray(int minValue, int maxValue, int rows, int columns)
{
    int [,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1); 
        }
    }
return newArray; 
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j]+ " "); 
        }
        Console.WriteLine(); 
    }
}
int[,] ColumnsSum(int[,] array, int rows)
{   
    
    
    for(int j =0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = (result +array[i,j]);
            
        }
        result = result/rows;
        Console.WriteLine($"Среднее арифметическое значение столбцов {result}");
    }
    Console.WriteLine();
    return array;
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray =  Creat2DRandomArray(min, max, rows, columns);
Show2DArray(myArray);
ColumnsSum(myArray, rows);*/
