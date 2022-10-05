// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int N = Prompt("Задайте N ");
WriteNaturalNumbers(N);


int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

void WriteNaturalNumbers(int N)
{
    System.Console.Write(N+" ");
    if (N > 1) WriteNaturalNumbers(N-1);
}
