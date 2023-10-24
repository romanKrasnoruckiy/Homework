// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// int FindQuarter(int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     else if(x < 0 && y > 0) return 2;
//     else if(x < 0 && y < 0) return 3;
//     else if(x > 0 && y < 0) return 4;
//     return 0;
// }

// Console.Write("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// // int quarter = FindQuarter(x, y); строка должна быть закомментирована, или закомментировать последнюю!
// // Console.WriteLine(quarter); строка должна быть закомментирована, или закомментировать последнюю!
// Console.WriteLine(FindQuarter(x, y));


// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//     double result = Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
//     return result;
//     // или: return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
// }

// Console.Write("Input XA: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input YA: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input XB: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input YB: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"A({xa}, {ya}), B({xb}, {yb}) -> {FindDistance(xa, ya, xb, yb)}");


// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

// void FindQuarter(int a)
// {
//     if(a == 1)
//     {
//         Console.WriteLine("x+, y+");
//     }
//     else if(a == 2)
//     {
//         Console.WriteLine("x-, y+");
//     }
//     else if(a == 3)
//     {
//         Console.WriteLine("x-, y-");
//     }
//     else if(a == 4)
//     {
//         Console.WriteLine("x+, y-");
//     }
//     else
//     {
//         Console.WriteLine("Такой четверти не существует");
//     }

// }
// Console.Write("Введите номер четверти: ");
// int a = Convert.ToInt32(Console.ReadLine());
// FindQuarter(a);


// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// void SqearesTable(int n)
// {
//     int current = 1;
//     while (current <= n)
//     {
//         Console.Write($"{current * current}, ");
//         current++;
//     }
// }
// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SqearesTable(n);