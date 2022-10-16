// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();
Write("Введите занчение N: ");
int number = int.Parse(ReadLine()!);
NaturalNumbers(number);
WriteLine();

void NaturalNumbers(int num)
{
    if (num == 0) return;
    Write($"{num}  ");
    NaturalNumbers(num - 1);
}
