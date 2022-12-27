// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
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

int SearchElement(int[,] matrix, int x, int y)
{
    int elem = -1;
    // проверяем, что бы номер элемента был меньше или равен размеру нашей матрицы
    // элемент должен быть меньше на единицу для визуального восприятия пользователем
    if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1)) elem = matrix[x - 1, y - 1];
    return elem;
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
            Console.ForegroundColor = col[new System.Random().Next(0, 15)];
            Console.Write(matrix[i, j] + "   ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}


int X = ReadData("Введите номер строчки искомого элемента ");
int Y = ReadData("Введите номер столбца искомого элемента ");
int[,] arr2D = Fill2DArray(10, 10, 10, 99);
Print2DArrayColor(arr2D);
if (SearchElement(arr2D, X, Y) != -1) PrintData("Искомый элемент массива: ", SearchElement(arr2D, X, Y));
else Console.WriteLine("Такого элемента нет");