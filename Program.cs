/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
/*
double [,] RandomArray(int rows, int columns, int digit, double minValue, double maxValue)
{   
    double [,] array = new double [rows, columns]; // Создание массива
    {
    double decim = Convert.ToDouble(digit);// Преобразуем в double  
    int dec = Convert.ToInt32(Math.Pow(10, digit));//Нужное ко-во знаков после запятой
    minValue = Math.Round(minValue, digit); // Округляем параметр
    minValue *= dec; // Целое число для метода Random.Next
    int minV = Convert.ToInt32(minValue); // Преобразуем в Int   
    maxValue = Math.Round(maxValue, digit); // Округляем параметр
    maxValue *= dec; // Целое число для метода Random.Next
    int maxV = Convert.ToInt32(maxValue);// Преобразуем в Int 
        for(int i = 0; i < rows; i++)
        {           
            for(int j = 0; j < columns; j++) 
             {  
                array[i, j] = Math.Round((new Random().NextDouble() * (new Random().Next(minV, maxV))) /  dec, digit); // Округляем до заданного количества 
             }
        }                      // знаков после запятой в массиве случайную величину, заполняем массив
    return array;
    }
}        
void ShowArray(double[,] array)
{       
    Console.WriteLine("Your Array:");
    for(int i = 0; i < array.GetLength(0); i++)
    {        
        for(int j = 0; j < array.GetLength(1); j++) 
            Console.Write(array[i, j] + "| ");
    Console.WriteLine();
    }        
    Console.WriteLine();   
}
Console.WriteLine("Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colomns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the number of decimal places:");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input  of possible value:");
int  min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum of possible value:");
int max = Convert.ToInt32(Console.ReadLine());
double [,] myRandomArray = RandomArray(m, n, d, min, max);
ShowArray(myRandomArray);
*/
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

/*int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // Метод для создания двумерного int массива и его вывода
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)        
        for(int j = 0; j < columns; j++)   
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;        
}
void Show2dArray(int[,] array)  //                                  Метод вывода массива 2D
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "| ");
        Console.WriteLine();    
    }
    Console.WriteLine(); 
}
bool FindoutElement(int[,] array) // Метод лпределения присудствия элемента в массиве 
{
    int i = array.GetLength(0) - 1;
    int j = array.GetLength(1) - 1;
    if(i < array.GetLength(0) && j < array.GetLength(1))
        return true;       
    else
        return false;
}
Console.WriteLine("Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum of possible value:");
int  min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum of possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myRandomArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myRandomArray);
Console.WriteLine("Input number of your rows:");
int rowE = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of your columns:");
int columnsE = Convert.ToInt32(Console.ReadLine());
bool x = FindoutElement(myRandomArray);
   if (x == true)
       Console.Write($"The element in the array is:  {myRandomArray[rowE - 1, columnsE - 1]}");       
    else
        Console.WriteLine($"Index  was  outside the bounds of the array");  
*/        
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:  
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // Метод создания массива 2D, заполненного случайными Int
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)        
        for(int j = 0; j < columns; j++)   
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;        
}

void Show2dArray(int[,] array)  //                                  Метод вывода массива 2D Int
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "| ");
        Console.WriteLine();    
    }  
}
void ArithmeticMeanCoulnm2dArray(int[,] array)  //  Метод подсчета сред. арифметич. массива 2D Int, вывод double 
{ 
         for(int j = 0 , k = 0; j < array.GetLength(1); j++, k++)            
           {       
            Double summ =  0;         
            for(int i = 0;   i < array.GetLength(0); i++)
                summ += array[i,j];             
        Console.Write(summ / array.GetLength(0) + "| ");          
           }             
}
Console.WriteLine("Input number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colomns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a minimum of possible value:");
int  min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum of possible value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myRandomArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myRandomArray);
Console.WriteLine("Arithmetic Mean of Coulnm in Yor Array");
ArithmeticMeanCoulnm2dArray(myRandomArray);
*/