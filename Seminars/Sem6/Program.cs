// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
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
//     ReverseArray(myArray);
//     PrintArray(myArray);





// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


//  void DecimalToBinary(int num)
//  {
//     string str = string.Empty;
//     while (num > 0)
//     {
//         str = num % 2 + str;
//         num /= 2;
//     }
//     Console.WriteLine(str);
//  }

//  Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// DecimalToBinary(num);





// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.


// void Triangle(int a, int b, int c)
// {
//     if((a + b > c) & (b + c > a) & (a + c > b))
//     {
//         Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} может существовать");
//     }
//     else Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не может существовать");
// }

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Triangle(a, b, c);




// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int[] FibonacciNumbers(int n)
// {
//     int[] array = new int [n];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();

// }

// Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// PrintArray(FibonacciNumbers(n));