// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу
// которая покажет количество чётных чисел в массиве
// * Отсортировать массив методом пузырька

int[] array = GenArray(100, 100, 999);
PrintArray(array);
Console.WriteLine();
BubbleSort(array);
PrintArray(array);
Console.WriteLine();
int result = CountEven(array);
PrintData("Количество чётных чисел в массиве " + result);

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
int[] BubbleSort(int[] arr) // Метод сортирует наш массив методом "Пузырька"
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
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
int CountEven(int[] arr) // Метод считает количество чётныхчисел в массиве
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}