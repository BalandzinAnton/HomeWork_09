// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

using static System.Console;
Clear();
Write("Введите занчение M: ");
int numberM = int.Parse(ReadLine()!);
Write("Введите занчение N: ");
int numberN = int.Parse(ReadLine()!);
int result = FuncAkkerman(numberM, numberN);
WriteLine(result);

int FuncAkkerman(int n, int m)
{
    if(n == 0)
        return m + 1; 
    else
        if((n != 0) && (m == 0))
            return FuncAkkerman(n - 1, 1); 
        else
            return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
}


