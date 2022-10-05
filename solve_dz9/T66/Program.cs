// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int M = Prompt("Задайте M ");
int N = Prompt("Задайте N ");
int tmp;
if (M>N)
{
    tmp = M;
    M=N;
    N=tmp;
}

System.Console.Write(SumOfNumbersBetweenNandM(M, N));

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int SumOfNumbersBetweenNandM(int M, int N)
{
    if (N==M) return N;
    return N+= SumOfNumbersBetweenNandM(M, N-1);
}

