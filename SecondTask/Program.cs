// Задайте значения M и N. Напишите программу, которая найдет сумму 
// натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int M = Math.Abs(Convert.ToInt32(Console.ReadLine() ?? string.Empty));
Console.WriteLine("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine() ?? string.Empty));
int temp = M;
if (M > N)
{
    M = N;
    N = temp;
}
PrintSumm(M, N , temp = 0);
void PrintSumm(int M, int N, int sum)
{
    sum = sum + N;
    if ( N <= M)
    {
        Console.Write($"Сумма всех элементов -> {sum} ");
        return;
    }
    PrintSumm(M, N - 1, sum);
}


