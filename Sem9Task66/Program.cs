// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int N = ReadData("Enter number N: ");
int M = ReadData("Enter number M: ");
int sum = N < M ? SumRec(N, M) : SumRec(M, N); // Проверка на порядок ввода элементов
PrintResult(sum);

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(int prefix)
{
    Console.Write(prefix);
}

// Метод считает сумму элементов от одного числа до другого
int SumRec(int num1, int num2)
{
    if (num1 >= num2) return num2;
    int sumRec = num1 + SumRec(num1 + 1, num2);
    return sumRec;
}