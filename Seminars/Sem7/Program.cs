// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) ; j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] myMatrix = CreateMatrix(rows, columns, minValue, maxValue);
//     PrintMatrix(myMatrix);




// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) ; j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumOfMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) ; j++)
//         {
//             if(i == j) sum += matrix[i,j];
//         }
//     }
//     return sum;
// }

//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] myMatrix = CreateMatrix(rows, columns, minValue, maxValue);
//     PrintMatrix(myMatrix);
//     Console.WriteLine(SumOfMainDiagonal(myMatrix));




// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) ; j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateAmnMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = i + j;
//         }
//     }
//     return matrix;
// }

//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] myMatrix = CreateAmnMatrix(rows, columns);
//     PrintMatrix(myMatrix);




// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) ; j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] SquaringEvenNumbers(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) ; j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] =  matrix[i, j] *  matrix[i, j];
//             }
//         }
//     }
//     Console.WriteLine();
//     return matrix;
// }

//  Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] myMatrix = CreateMatrix(rows, columns, minValue, maxValue);
//     PrintMatrix(myMatrix);
//     myMatrix = SquaringEvenNumbers(myMatrix);
//     PrintMatrix(myMatrix);


