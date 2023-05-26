// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{

    if (N == M)
    {
        return N;
    }


    return N + SumNumbers(M, N -1);



}

int firstNumber = ReadInt("Введите число M: ");
int lastNumber = ReadInt("Введите число N: ");

System.Console.WriteLine(SumNumbers(firstNumber, lastNumber));


