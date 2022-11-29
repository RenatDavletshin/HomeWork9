// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M: ");
int M = Math.Abs(Convert.ToInt32(Console.ReadLine() ?? string.Empty));
Console.WriteLine("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine() ?? string.Empty));

Console.WriteLine($"A(M,N) = {AckermanFunction(M, N)}");
int AckermanFunction(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return AckermanFunction(M - 1, 1);
    else return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
}