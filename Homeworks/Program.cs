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







