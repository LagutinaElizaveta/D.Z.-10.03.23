// Задайте значения M и N. Напишите программу, которая
// найдет сумму всех натуральных элементов в промежутке
// от M до N. Например: M=1; N=15. -> 120
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
// Метод нахождения суммы натуральных элементов
int SumElements(int M, int N)
{
    if (M == N)
    {

        return N;
    }
    else
    {
        return (M + SumElements(M + 1, N));
    }
}
Console.WriteLine($"Сумма всех натуральных элементов в промежутке от {M} до {N} равна {SumElements(M, N)}");