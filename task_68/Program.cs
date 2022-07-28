//задача 68, Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

double FunAckermann (double m,  double n )
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0 ) return FunAckermann(m-1, 1);
    if (m > 0 && n > 0) return FunAckermann (m-1, FunAckermann(m, n-1));
    return FunAckermann(m, n);
}

Console.WriteLine(FunAckermann ( 3, 2));