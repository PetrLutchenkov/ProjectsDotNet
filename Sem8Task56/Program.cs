// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i, j] % 14];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Генерируем двумерный массив, заполненный случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод находит индекс строки с минимальной суммой её элементов
int MinRow(int[,] array2D)
{
    int minIndex = -1;
    int minRow = int.MaxValue;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        if (minRow > sum)
        {
            minRow = sum; minIndex = i;
        }
    }
    return minIndex;
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

int row = ReadData("Введите количество строк ");                        // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов ");                  // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 0, 99);
Print2DArrayColor(arr2D);
PrintData("Номер строки с минимальной суммой элементов " + (MinRow(arr2D) + 1));