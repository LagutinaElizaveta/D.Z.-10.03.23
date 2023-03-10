// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m=2, n=3. ->A(m, n)=29
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
// Нахождение функции Аккермана
int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    return n + 1;
}
Console.WriteLine($"Функция Аккермана для чисел {m} и {n} равна {Ackerman(m, n)}");