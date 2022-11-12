//aka.ms/new-console-template for more information
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// Console.WriteLine("введите m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите n");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[m, n];
// FillArrayNumbers(numbers);
// PrintArray(numbers);

// void FillArrayNumbers(double[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
    
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write($"{array[i, j]} ");
//         }
        
//        Console.Write(" ");
//        Console.WriteLine(" "); 
// }

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [10,10];

// FillArray(numbers);
// PrintArray(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100);
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write(" ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write(" ");
//         Console.WriteLine(" "); 
//     }
// }
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Console.WriteLine("введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[n, m];
// FillArray(array);
// PrintArray(array);

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum = 0;
//     double srz =0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = (sum + array[i, j]);
//     }
//     srz = sum / n;
//     Math.Round(srz, 1, MidpointRounding.ToEven);

//     Console.Write( srz + "; ");
// }
// Console.WriteLine();


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
       
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
      
//         Console.WriteLine("");
//     }
// }

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int[,] table = new int[3, 4];
// FillArrayRandom(table);
// PrintArray(table);
// SortToLower(table);
// Console.WriteLine();
// PrintArray(table);

// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// int[,] table = new int[4, 4];
// FillArray(table);
// PrintArray(table);
// Console.WriteLine();
// NumberStrMinSumElements(table);

// // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
// void NumberStrMinSumElements(int[,] array)
// {
//     int minStr = 0;
//     int minSumStr = 0;
//     int sumStr = 0;
//     for (int i = 0; i < table.GetLength(1); i++)
//     {
//         minStr += table[0, i];
//     }
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++) sumStr += table[i, j];
//         if (sumStr < minStr)
//         {
//             minStr = sumStr;
//             minSumStr = i;
//         }
//         sumStr = 0;
//     }
//     Console.Write($"{minSumStr + 1} строка");
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
	// Например, даны 2 матрицы:
	// 2 4 | 3 4
	// 3 2 | 3 3
	// Результирующая матрица будет:
	// 18 20
	// 15 18
	
	 int rows = ReadInt("Введите количество строк матрицы 1: ");
	 int columns = ReadInt("Введите количество столбцов матрицы 1: ");
     int rows1 = ReadInt("Введите количество строк матрицы 2: ");
	 int columns1 = ReadInt("Введите количество столбцов матрицы 2: ");
	 int[,] array = new int[rows, columns];
	 int[,] secondArray = new int[rows1, columns1];
	 int[,] resultArray = new int[rows, columns];
	
	FillArray(array);
	PrintArray(array);

	Console.WriteLine();

	FillArray(secondArray);
	PrintArray(secondArray);
	
	Console.WriteLine();
	
	if (array.GetLength(0) != secondArray.GetLength(1))
	{
	    Console.WriteLine("Матрицы нельзя перемножить ");
	    return;
	}
	for (int i = 0; i < array.GetLength(0); i++)
	{
	    for (int j = 0; j < secondArray.GetLength(1); j++)
	    {
	        resultArray[i, j] = 0;
	        for (int k = 0; k < array.GetLength(1); k++)
	        {
	            resultArray[i, j] += array[i, k] * secondArray[k, j];
	        }
	    }
	}
	
	PrintArray(resultArray);
	
	int ReadInt(string message)
	{
	    Console.Write(message);
	    return Convert.ToInt32(Console.ReadLine());
	}
	
	void FillArray(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = new Random().Next(1, 10);
	        }
	    }
	}
	
	void PrintArray(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write($"{array[i, j]} ");
	        }
	        Console.WriteLine();
	    }
	}
