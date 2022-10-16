// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using static System.Console;
Clear();
WriteLine("Ввидите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число N ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum = SumNaturalNumbersMN(m, n);
WriteLine($"Сумма цифр от числа {m} до {n} = {Sum}");


int SumNaturalNumbersMN(int m, int n)
{
    int result = 0;
    if (n>m)
    {
    if( n == m )  return result;
    result = n + SumNaturalNumbersMN(m, n - 1); 
    }
    if (m>n)
    {
    result = n;
    if( n == m )  return result;
    result = m + SumNaturalNumbersMN(m-1, n);
    }
    if( n == m )
    result += n;
    return result;
}