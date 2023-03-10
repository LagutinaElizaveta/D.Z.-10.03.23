// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.
// M=1; N=5. -> "5, 4, 3, 2, 1"
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
// Метод вывода чисел в обратном порядке
string PrintNumbers(int M, int N)
{
    if (N == M)
    {
        Console.WriteLine(N);
        return N.ToString();
    }
    else
    {
        string s = N.ToString() + "  " + PrintNumbers(M, N - 1);
        return s;
    }
}
Console.WriteLine($"{PrintNumbers(M, N)} ");
