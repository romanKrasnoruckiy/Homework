// Напишите программу, которая выводит случайное трёхзначное число и удаляет
// вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// void DeleteSecondDigit()
// {
//     int randomNum = new Random().Next(100, 1000);
//     // int ed = randomNum % 10;
//     // int sot = randomNum / 100;
//     // Console.WriteLine($"{randomNum} -> {sot * 10 + ed}");
//     Console.WriteLine($"{randomNum} -> {randomNum / 100 * 10 + randomNum % 10}");
// }
// DeleteSecondDigit();


// Напишите программу, которая будет принимать на вход два числа и будет выводить, является ли второе
// число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток
// от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void CheckMiltiplicity(int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         Console.WriteLine($"{num1}, {num2} -> multiple");
//     }
//     else
//     {
//         Console.WriteLine($"{num1}, {num2} -> not multiple, remainder -> {num1 % num2}");
//     }

// }

// Console.Write("Input first num: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second num: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// CheckMiltiplicity(n1, n2);


// Напишите программу которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// 78 -> 8

// 12 -> 2

// 85 -> 8

// int FindBiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(dec < ed) return ed;
//     else return dec;
// }

// int randomNum = new Random().Next(10, 99 + 1);
// int biggestDigit = FindBiggestDigit(randomNum);
// Console.WriteLine($"{randomNum} -> {biggestDigit}");


// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// 14 -> нет
// 46 -> нет
// 161 -> да


// bool CheckMiltiplicity(int num)
// {
//     if(num % 7 == 0 && num % 23 == 0)
//     return true;
//     else
//     return false;
// }
    
// Console.Write("Input first num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool multiple = CheckMiltiplicity(num);
// Console.WriteLine($"{num} -> {multiple}");


//  Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// void CheckSquare(int num1, int num2)
// {
//     if(num1 == num2 * num2)
//     Console.WriteLine("Является");
//     else
//     Console.WriteLine("Не является");
// }

// CheckSquare(25, 5);

