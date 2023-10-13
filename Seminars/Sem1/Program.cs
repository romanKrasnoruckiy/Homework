//Console.Write("Input your age: ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Your age -> {age} !!! ");

// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// **Например:**

// 4 -> 16
// -3 -> 9
// -7 -> 49

//Console.Write("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{num} -> {num * num}");

// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю**
// цифру этого числа.

//   456 -> 6

//   782 -> 2

//   918 -> 8

//Console.Write("Input three-digit number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num >= 100 && num <= 999)
//{
//    Console.WriteLine($"{num} -> {num % 10}");
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}

// Напишите программу , которая на вход принимает одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

//Console.Write("Input N: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int current = -1 * n;
//Console.Write($"{n} -> ");
//while(current <= n)
//{
//    Console.Write(current + " ");
//    current++;  // current = current + 1; current += 1;
//}

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 - Среда
// 5 - Пятница

//Console.Write("Input day number: ");
//int dNum = Convert.ToInt32(Console.ReadLine());
//if(dNum == 1)
//{
//    Console.WriteLine($"{dNum} -> Понедельник ");
//} else if(dNum  == 2)
//{
//    Console.WriteLine($"{dNum} -> Вторник ");
//} else if(dNum  == 3)
//{
//    Console.WriteLine($"{dNum} -> Среда ");
//} else if(dNum  == 4)
//{
//    Console.WriteLine($"{dNum} -> Четверг ");
//} else if(dNum  == 5)
//{
//    Console.WriteLine($"{dNum} -> Пятница ");
//} else if(dNum  == 6)
//{
//    Console.WriteLine($"{dNum} -> Суббота ");
//} else if(dNum  == 7)
//{
//    Console.WriteLine($"{dNum} -> Воскресенье ");
//} else
//{
//    Console.WriteLine("Invalid input");
//}

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// a = 25; b = 5 -> да
// a = 2; b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3; b = 9 -> нет

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b * b == a)
{
    Console.WriteLine($"{a} is quad of {b}");
}
else
{
    Console.WriteLine($"{a} is not quad of {b}");
}