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

