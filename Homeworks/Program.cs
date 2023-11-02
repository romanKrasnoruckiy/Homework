// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит,
// какое число большее, а какое меньшее.

// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         if(firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
//         }else if(firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
//         }else
//         {
//             Console.WriteLine($"Введенные числа равны `{firstNumber}`");
//         }

//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 17;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// Внутри класса Answer напишите метод FindMax, 
// который принимает на вход три числа и выдаёт максимальное из этих чисел.

// using System;

// public class Answer {

//   static int FindMax(int a, int b, int c)
//     {
//        int max = a;
//         if (max < b)
//         {
//             max = b;
//         }
//         if (max < c)
//         {
//             max = c;
//         }
//         return max;

//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 5;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

// Внутри класса Answer напишите метод CheckIfEven,который на вход принимает число number и
// выводит, является ли число чётным (делится ли оно на два без остатка).

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       if(number % 2 == 1)
//       {
//          Console.WriteLine($"Число `{number}` нечётное");
//       }else
//       {
//         Console.WriteLine($"Число `{number}` чётное");
//       }


//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 17;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

//  Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число
//  (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком
//  табуляции.

// using System;
// using System.Data;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//        for (int count = 2; count <= number; count += 2)
//         {
//             Console.Write($"{count}\t");
//         }

//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 17;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// void ThreeDigitNumbers()
// {
//     Console.Write("Enter a three-digit number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if(number >= 100 && number <= 999)
//     {
//     int units = number / 10;
//     int hundreds = units % 10;
//     Console.WriteLine($"{number} -> {hundreds}");
//     }
//     else
//     {
//     Console.WriteLine("Invalid input");
//     }
// }
// ThreeDigitNumbers();


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void CheckDayOfWeek()
// {
//     Console.Write("Input day number: ");
//     int dNum = Convert.ToInt32(Console.ReadLine());
//     if(dNum == 1)
//     {
//     Console.WriteLine($"{dNum} -> Понедельник - не является выходным днём");
//     } else if(dNum  == 2)
//     {
//     Console.WriteLine($"{dNum} -> Вторник - не является выходным днём");
//     } else if(dNum  == 3)
//     {
//     Console.WriteLine($"{dNum} -> Среда - не является выходным днём");
//     } else if(dNum  == 4)
//     {
//     Console.WriteLine($"{dNum} -> Четверг - не является выходным днём");
//     } else if(dNum  == 5)
//     {
//     Console.WriteLine($"{dNum} -> Пятница - не является выходным днём");
//     } else if(dNum  == 6)
//     {
//     Console.WriteLine($"{dNum} -> Суббота - является выходным днём");
//     } else if(dNum  == 7)
//     {
//     Console.WriteLine($"{dNum} -> Воскресенье - является выходным днём");
//     } else
//     {
//     Console.WriteLine("Invalid input");
//     }

// }
// CheckDayOfWeek();


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int ThirdDigit()
// {
//     Console.Write("Input number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if(number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         while(number > 999)
//         {
//             number /= 10;
//             Console.WriteLine($"Третья цифра из числа будет -> {number % 10}");
//         }
//         return number % 10;

//     }
//     return number % 10;

// }
// ThirdDigit();


// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число 
// number и проверяет, является ли оно палиндромом. Метод должен проверить является ли число пятизначным,
// в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.

// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False


// using System;
// using System.Diagnostics.CodeAnalysis;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже

//        if (number < 10000 || number >= 100000){
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }
//         return reverse == number;


// if(number >= 10000 && number <= 99999)
// {
//   int n5 = number % 10;
//   int n4 = number / 10 % 10;
//   int n3 = number /100 % 10;
//   int n2 = number / 1000 % 10;
//   int n1 = number / 10000;
//   Console.Write($"{number} -> ");

//   if(n1 == n5 || n2 == n4)
//   return true;
//   else
//   return false;

// }
// else
// Console.WriteLine($"{number} -> Число не пятизначное");
// return false;


// }

// Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }




// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) 
// и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

// using System;

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//       // Введите свое решение ниже

//        for (int i = 1; i<= N ;i++)
//         {
//             int k = i*i*i;
//             Console.WriteLine(k);
//         }

//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 6;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }


// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух 
// точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// using System;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
//       int x1 = pointA[0];
//       int y1 = pointA[1];
//       int z1 = pointA[2];

//       int x2 = pointB[0];
//       int y2 = pointB[1];
//       int z2 = pointB[2];

//       double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//       return distance;

//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Numbers(int a, int b)
// {
//   int result = 1;
//   for (int i = 1; i <= b; i++)
//   {
//     result = result * a;
//   }
//   return result;

//   }

// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Numbers(a, b));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int DigitConter(int num)
// {
//   int result = 0;
//   while (num > 0)
//   {
//     result = result + num % 10;
//     num /= 10;
//   }
//   return result;

// }


// Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num + " -> " + DigitConter(num));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int[8];
// array[0] = 15;
// array[1] = 8;
// array[2] = 3;
// array[3] = 41;
// array[4] = 7;
// array[5] = 19;
// array[6] = 11;
// array[7] = 17;
// for (int i = 0; i < array.Length; i++)
// {
//   Console.Write($"{array[i]}, ");
// }


// Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных 
// трехзначных чисел и выводит результат на экран.
// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных 
// чисел и возвращает количество четных элементов в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".
// Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
// который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.



// using System;

// public class Answer
// {
//     public static int CountEvenElements(int[] array)
//     { 
//     // Введите свое решение ниже
//         int evenCount = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if(array[i] > 0)
//             {
//                 if(100 <= array[i] || 999 >= array[i])
//                 {
//                   if((array[i] % 2) == 0) evenCount++;
//                 }
//             }
//         }
//         return evenCount;
//     }

//     public static void PrintArray(int[] array)
//     {
//     // Введите свое решение ниже
//         for(int i = 0; i < array.Length; i++)
//         {
//         Console.Write(array[i] + "  ");
//         }
//         Console.WriteLine();
//     }


// // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         // Не удаляйте строки ниже
//         Console.WriteLine("Массив:");
//         PrintArray(array);
//         int evenCount = CountEvenElements(array);
//         Console.WriteLine($"Количество четных элементов: {evenCount}");
//     }
// }



// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых 
// чисел и выводит результат на экран.
// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает 
// сумму элементов с нечетными индексами в массиве.
// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
// При выводе элементы массива должны быть разделены символом табуляции "\t".


// using System;

// public class Answer
// {
//     public static int SumOddElements(int[] array)
//     {
// // Введите свое решение ниже
//         int sumOdd = 0;
//         for (int i = 1; i < array.Length; i+=2)
//         {
//             if(i % 2 == 1) 
//             sumOdd = sumOdd + array[i];  
//         }
//         return sumOdd;


//     }

//     public static void PrintArray(int[] array)
//     {
//          // Введите свое решение ниже
//         for(int i = 0; i < array.Length -1; i++)
//         {
//         Console.Write(array[i] + "  ");
//         }
//         Console.WriteLine();

//     }


// // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         // Не удаляйте строки ниже
//         PrintArray(array);
//         int sumOdd = SumOddElements(array);
//         Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
//     }
// }



// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:
// FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и 
// возвращает максимальное число из массива.
// FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и 
// возвращает минимальное число из массива.
// CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных 
// чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
// PrintArray(double[] array): Метод для вывода массива на экран. Он принимает на вход массив 
// array и выводит его элементы с двумя знаками после запятой через табуляцию.


// using System;
// using System.ComponentModel.DataAnnotations;

// public class Answer
// {
//     public static double FindMax(double[] array)
//     {     // Введите свое решение ниже
//             double max = array[0];
//             for (int i = 1; i < array.Length; i++)
//             {
//               if (max < array[i])
//               {
//                 max = array[i];
//               }
//             }
//             return max ;

       
//     }

//     public static double FindMin(double[] array)
//     {     // Введите свое решение ниже
//             double min = array[0];
//             for (int i = 1; i < array.Length; i++)
//             {
//               if (min > array[i])
//               {
//                 min = array[i];
//               }
//             }
//             return min;


//     }

//     public static double CalcDifferenceBetweenMaxMin(double[] array)
//     {// Введите свое решение ниже
//         return FindMax(array) - FindMin(array);


//     }

//     public static void PrintArray(double[] array)
//     {// Введите свое решение ниже
//         for(int i = 0; i < array.Length - 1; i++)
//         {
//         Console.Write("  ");
//         }
//         Console.WriteLine();

//     }
//  // Не удаляйте и не меняйте метод Main! 


//     public static void Main(string[] args)
//     {
//         double[] array;
//         if (args.Length == 0)
//         {
//             array = new double[] { 3, 7.4, 22.3, 2, 78 };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в массив чисел
//             string[] argStrings = args[0].Split(", ");
//             array = new double[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (double.TryParse(argStrings[i], out double number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         Console.WriteLine("Массив:");
//         PrintArray(array);
//         double diff = CalcDifferenceBetweenMaxMin(array);
//         Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
//     }
// }


