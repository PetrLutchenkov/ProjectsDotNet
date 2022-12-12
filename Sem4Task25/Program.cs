// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A внатуральную степень B

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(long res)
{
    Console.WriteLine(res);
}
long Pow(int num1, int num2)
{
    long res = 1;
    for (int i = 0; i <= num2; i++)
    {
        res = num1*res;
    }
    return res;
}
int A = ReadData("Введите первое число ");
int B = ReadData("Введите второе число ");
long result = Pow(A,B);
PrintData(result);