//задание 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("введите первое число ");
 int m = Convert.ToInt32(Console.ReadLine());
  Console.Write("введите второе число ");
 int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers ( int m, int n)
{
    if (m == n) return n;
    return m + SumNumbers (m+1, n);
}

Console.WriteLine ("сумма всех чисел в заданном диапозоне"+ SumNumbers(m, n));