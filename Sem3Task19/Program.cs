//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int num = ReadData("Введите пятизначное число: ");
PrintPalinTest(num);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод определяющий палиндром
void PrintPalinTest(int n)
{
    if (n > 9999 && n < 100000)
    {
        if (n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10) Console.WriteLine("Да");
        else Console.WriteLine("Нет");
    }
    else Console.WriteLine("Вы ввели не пятизначное число!");
}