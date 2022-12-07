/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
/*int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
     {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
     }
  }
  return newArray;    
}

void Show2DArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0) ;i++ ) 
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
}
int[,] ChangeArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0) ; i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
         for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[i, a] < array[i, a + 1])
                {
                    int temp = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = temp;
                }
            }
         }
     
    }
    return array;
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m,n,min,max); 
Show2DArray(myArray);
Console.WriteLine();
myArray = ChangeArray(myArray);
Show2DArray(myArray);*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


/*int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
        {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
  return newArray;    
}
void Show2DArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0) ;i++ ) 
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
}
void FindMinSum(int [,] array)
{
    int minIndex = 0;
    int minSum = 0;
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minIndex += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             sum += array[i, j];
        }
        if (sum < minIndex)
        {
            minIndex = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"Строка с наименьшей суммой -> {minSum + 1}");
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m,n,min,max); 
Show2DArray(myArray);
FindMinSum(myArray);*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/*int[,] CreateArray1(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
        {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
  return newArray;    
}
int[,] CreateArray2(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
        {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
  return newArray;    
}
void Show2DArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0) ;i++ ) 
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
}
int[,] NewMatrix(int [,] array1 , int [,] array2)
{
    if(array1.GetLength(1)!= array2.GetLength(0))
    Console.WriteLine("Произведение двух матриц невозможно");
    int rows = array1.GetLength(0);
    int columns = array2.GetLength(1);

int[,] newArray = new int[rows, columns];  
{

  for (int i = 0; i < rows; i++)
     {
     for(int j = 0; j < columns; j++)
     {
        for (int k = 0; k < array1.GetLength(1); k++)
        newArray[i,j] += array1[i,k] * array2[k,j];
     }
     }
    return newArray;
    
}

}

Console.Write("Введите количество строк 1 массива ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение 1 массива ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение 1 массива ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2 массива ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 массива ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение 2 массива ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение 2 массива ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreateArray1(m1,n1,min1,max1); 
int[,] myArray2 = CreateArray2(m2,n2,min2,max2); 

Show2DArray(myArray1);
Console.WriteLine();
Show2DArray(myArray2);
Console.WriteLine();
Show2DArray(NewMatrix(myArray1, myArray2));*/



/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/



/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*int n = 4;
int[,] SpiralArray = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpiralArray.GetLength(0) * SpiralArray.GetLength(1))
{
  SpiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < SpiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SpiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SpiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
ShowArray(SpiralArray);*/