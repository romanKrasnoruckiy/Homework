// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//      int[] array = new int[size];
//      for(int i = 0; i < size; i++)
//      {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//      }
//      return array;
// }

//  void PrintArray(int[] array)
//  {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void PosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     Console.WriteLine($"Sum of Positive elements -> {sumPos}, sum of negative -> {sumNeg}");
// }
//     Console.Write("Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[] myArray = CreateRandomArray(size, minValue, maxValue);
//     PrintArray(myArray);
//     PosNegSum(myArray);



// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//      int[] array = new int[size];
//      for(int i = 0; i < size; i++)
//      {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//      }
//      return array;
// }

//  void PrintArray(int[] array)
//  {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int Counter(int[] array, int min, int max)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= min && array[i] <= max) counter++;
//     }
//     return counter;
// }
    
//     Console.Write("Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the minimum value of the segment in which you want to find elements: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the maximum value of the segment in which you want to find elements: ");
//     int max = Convert.ToInt32(Console.ReadLine());


//     int[] myArray = CreateRandomArray(size, minValue, maxValue);

//     PrintArray(myArray);
//     Console.WriteLine(Counter(myArray, min, max));


// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


//  int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//      int[] array = new int[size];
//      for(int i = 0; i < size; i++)
//      {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//      }
//      return array;
// }

//  void PrintArray(int[] array)
//  {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// bool FindNumber(int[] array, int num)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == num)
//         return true;
//     }
//     return false;
// }

//     Console.Write("Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Input num: ");
//     int num = Convert.ToInt32(Console.ReadLine());


//     int[] myArray = CreateRandomArray(size, minValue, maxValue);
//     PrintArray(myArray);
//     Console.WriteLine($"{num} -> {FindNumber(myArray, num)} ");


// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

//  int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//      int[] array = new int[size];
//      for(int i = 0; i < size; i++)
//      {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//      }
//      return array;
// }

//  void PrintArray(int[] array)
//  {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void Reverse(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     array[i] = array[i] * (-1);
//     }
// }

//     Console.Write("Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[] myArray = CreateRandomArray(size, minValue, maxValue);
//     PrintArray(myArray);
//     Reverse(myArray);
//     PrintArray(myArray);



