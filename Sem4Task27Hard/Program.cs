// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// Сделать оценку времени алгоритма через вещественные числа и строки

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}
int SumDigitDiv(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}
int SumDigitString(int num)
{
    char[] arr = num.ToString().ToCharArray();
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}

int number = ReadData("Введите число ");

DateTime d1 = DateTime.Now;
int result1 = SumDigitDiv(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int result2 = SumDigitString(number);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма цифр методом деления равна: " + result1);
PrintData("Сумма цифр методом преобразования в массив равна: " + result2);