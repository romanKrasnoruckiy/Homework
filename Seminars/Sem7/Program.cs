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