// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double K1 = ReadData("Введите k1:");
double B1 = ReadData("Введите b1:");
double K2 = ReadData("Введите k2:");
double B2 = ReadData("Введите b2:");

// Вводим переменные, обозначающие координаты точки пересечения.
// По неизвестной мне причине программа ругается и не наботает, если объявляю переменные в методе PrintData
double x = IntPointX(K1, K2, B1, B2);
double y = IntPointY(K1, B1, x);

PrintData("Координаты точки пересечения прямых: " + x + ":" + y);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Метод определяет координату пересечения линий по оси абсцисс по формуле
double IntPointX(double k1, double k2, double b1, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
}
// Метод определяет координату пересечения линий по оси ординат по формуле
double IntPointY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}