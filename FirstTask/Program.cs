// Задайте значение N. Напишите программу, которая выведет все четные 
// числа в промежутке от N до 1.

Console.Write("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine() ?? string.Empty));
Console.WriteLine(Numbers(N));

string Numbers(int N)
{
    if (N > 0)
    {
       if (N % 2 == 0 && N > 0)
       {
        Console.Write($"{N}, ");
        return Numbers(N - 2);
       }
       if (N % 2 != 0 && N > 0)
       {
        N--;
        Console.Write($"{N}, ");
        return Numbers(N - 2);
       }
       else
       {
        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        Console.WriteLine(" ");
        return "";
       } 
    }
    else
    {
        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        Console.WriteLine(" ");
        return "";
    }
}