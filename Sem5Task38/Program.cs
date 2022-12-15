// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] array = GenArray(7, 0, 30);
PrintArray(array);
Console.WriteLine();
double min = double.MaxValue;
double max = double.MinValue;
MinMax(array);
PrintData("Разница между максимальным и минимальным элементами массива " + (max - min));

double[] GenArray(int len, int minValue, int maxValue) // Метод создаёт массив
{
    Random rnd = new Random();
    double[] outArray = new double[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return outArray;
}
void PrintArray(double[] arr) // Метод выводит в консоль сгенерированный массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
void PrintData(string res) // Метод выводит данные пользователю
{
    Console.WriteLine(res);
}
void MinMax(double[] arr) // Метод определяет минимальный и максимальный элемент массива
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] < min) min = arr[i];
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > max) max = arr[i];
}