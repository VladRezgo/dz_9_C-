 
  //задание 64. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 Console.Write("введите первое число ");
 int a = Convert.ToInt32(Console.ReadLine());
  Console.Write("введите второе число ");
 int n = Convert.ToInt32(Console.ReadLine());
 
  
 string NumInterges (int a, int n)
{
    if (a == n) 
    {
        return n.ToString(); 
    }
    else 
    {
        return a.ToString() + " " + NumInterges(a+1 , n); 
    }
}


Console.Write("вcе натуральные числа в заданном диапазоне => "+ NumInterges(a,n));