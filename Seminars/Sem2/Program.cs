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
