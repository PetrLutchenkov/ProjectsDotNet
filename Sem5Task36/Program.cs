// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
// *Найдите все пары в массиве и выведите пользователю

int[] array = GenArray(6, -20, 20);
PrintArray(array);
Console.WriteLine();
int result = SumOdd(array);
PrintData("Сумма чисел, стоящих на нечётных позициях в массиве " + result);

int[] GenArray(int len, int minValue, int maxValue) // Метод создаёт массив
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}
void PrintArray(int[] arr) // Метод выводит в консоль сгенерированный массив
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
int SumOdd(int[] arr) // Метод считает сумму числел, стоящих на нечётных позициях
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}