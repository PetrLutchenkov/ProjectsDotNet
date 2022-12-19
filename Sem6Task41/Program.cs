//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int N = ReadData("Введите количество чисел:");
PrintData("Количество введённых чисел больше нуля: " + CountPosNum(N));

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод считает количество введённых пользователем положительных чисел
int CountPosNum(int M)
{
    int res = 0;
    while (M > 0)
    {
        if (ReadData("Введите число:") > 0) res++;
        M = M - 1;
    }
    return res;
}