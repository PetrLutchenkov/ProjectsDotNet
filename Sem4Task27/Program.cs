// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(int res)
{
    Console.WriteLine(res);
}
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}
int number = ReadData("Введите число ");
int result = SumDigit(number);
PrintData(result);