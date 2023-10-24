// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

// int DigitConter(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num + " -> " + DigitConter(num));


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

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
//  }

//     Console.Write("Input array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input minimal value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input maximal value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[] myArray = CreateRandomArray(size, minValue, maxValue);

//     // PrintArray(CreateRandomArray(size, minValue, maxValue));
//     PrintArray(myArray);


// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int Factorial(int n)
// {
//     int fact = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         fact = fact * (i);
//     }
//     return fact;
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factorial(n));

// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Number(int a)
// {
//     int num = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         num = num + i;
//     }
//     return num;
// }

// Console.Write("Input A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Number(a));