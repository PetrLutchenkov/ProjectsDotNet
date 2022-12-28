// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод заполняет трёх массива неповторяющимися числами
int[,,] Fill3DArray(int x, int y, int z)
{
    // Создаем одномерный массив, заполняем его двузначными цифрами
    int num = 10;
    int[] number = new int[90];
    for (int i = 0; i < 90; i++)
    {
        number[i] = num;
        num++;
    }

    // Перемешиваем одномерный массив
    for (int i = 0; i < 90; i++)
    {
        int index = new Random().Next(0, 90);
        int temp = number[index];
        number[index] = number[i];
        number[i] = temp;
    }

    // Заполняем трехмерный массив числами из перемешанного массива
    int numIndex = 0;
    int[,,] numArr3D = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                numArr3D[i, j, k] = number[numIndex];
                numIndex++;
            }
        }
    }
    return numArr3D;
}

// Метод печатает 3d массив с индексами
void Print3DArrayColor(int[,,] array3D)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.ForegroundColor = col[array3D[i, j, k] % 14];
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
int[,,] arr3D = Fill3DArray(3, 3, 3);
Print3DArrayColor(arr3D);