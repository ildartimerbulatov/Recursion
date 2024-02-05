// using System; 

// class Program // Определение класса программы.
// {
//     static void Main(string[] args) // Главный метод программы.
//     {
//         // Задаем значения M и N
//         int M = 1; // Начальное значение промежутка.
//         int N = 10; // Конечное значение промежутка.

//         // Вызываем метод для вывода натуральных чисел от M до N
//         PrintNaturalNumbers(M, N); // Вызов метода для вывода натуральных чисел.
//     }

//     static void PrintNaturalNumbers(int m, int n) // Метод для вывода натуральных чисел от m до n.
//     {
//         if (m <= n) // Проверка, что текущее число m не превышает n.
//         {
//             Console.WriteLine(m); // Вывод текущего числа на консоль.
//             PrintNaturalNumbers(m + 1, n); // Рекурсивный вызов метода для следующего числа.
//         }
//     }
// }




// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Определение значений m и n
//         int m = 2;
//         int n = 1;

//         // Вывод результата функции Аккермана
//         Console.WriteLine($"Аккерман({m}, {n}) = {AckermannFunction(m, n)}");
//     }

//     // Метод для вычисления функции Аккермана с помощью рекурсии
//     static int AckermannFunction(int m, int n)
//     {
//         // Базовые случаи
//         if (m == 0)
//             return n + 1;
//         else if (m > 0 && n == 0)
//             return AckermannFunction(m - 1, 1);
//         else // m > 0 && n > 0
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }




// using System;

// class Program
// {
//     static void PrintArrayReversed(int[] arr, int index)
//     {
//         if (index < 0 || index >= arr.Length)
//             return;

//         PrintArrayReversed(arr, index + 1);
//         Console.Write(arr[index] + " ");
//     }

//     static void Main(string[] args)
//     {
//         int[] array = { 1, 2, 3, 4, 5 };

//         Console.WriteLine("Элементы массива в обратном порядке:");
//         PrintArrayReversed(array, 0);
//     }
// }