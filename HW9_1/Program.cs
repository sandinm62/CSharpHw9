//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 

void PrintNubers(int m)
{
    if(m < 1)
    {
        return;
    }
    System.Console.Write(m + " ");
    PrintNubers(m - 1);
}



System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNubers(n);
