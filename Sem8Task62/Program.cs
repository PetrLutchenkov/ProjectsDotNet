// Программа, которая заполняет спирально массив (квадратный и прямоугольный)
//программа
int m = ReadData("Введите количество строк (не более 9) --->  ");
int n = ReadData("Введите количество столбцов (не более 9)--->  ");

int[,] NewMatrix = InitMatrix(m, n);

DateTime d1 = DateTime.Now;
int[,] arr1 = Gen2ArrSpir(m, n);
PrintResult("Решение Ирины " + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
int[,] arr2 = FillSpiralMatrix(m, n);//
PrintResult("Решение Любви " + (DateTime.Now - d2));

DateTime d3 = DateTime.Now;
int[,] arr3 = FillSpiral(NewMatrix);//
PrintResult("Решение рекурентное" + (DateTime.Now - d3));

// Console.WriteLine("Сформированный спиральный массив:");
// Print2DArr(arr1);
// Console.WriteLine("Сформированный спиральный массив:");
// Print2DArr(arr2);
// Console.WriteLine("Сформированный спиральный массив:");
// Print2DArr(arr3);

//метод ввода данных
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод, принимает строку, выводит в консоль
static void PrintResult(string line)
{
    Console.WriteLine(line);
}
//метод заполнения массива по спирали
//Ирина Пронько
int[,] Gen2ArrSpir(int m, int n)
{
    int[,] arr = new int[m, n];
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= m * n)
    {
        arr[i, j] = k;
        if (i == Ibeg && j < n - Jfin - 1)
            ++j;
        else if (j == n - Jfin - 1 && i < m - Ifin - 1)
            ++i;
        else if (i == m - Ifin - 1 && j > Jbeg)
            --j;
        else
            --i;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != n - Jfin - 1))
        {
            ++Ibeg;
            ++Ifin;
            ++Jbeg;
            ++Jfin;
        }
        ++k;
    }
    return arr;
}

//Любовь Радионова
int[,] FillSpiralMatrix(int n, int m)
{
    var result = new int[n, m];

    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int changes = 0;
    int visits = m;

    for (int i = 0; i < result.Length; i++)
    {
        result[row, col] = i + 1;

        if (--visits == 0)
        {
            visits = m * (changes % 2) + n * ((changes + 1) % 2) - (changes / 2 - 1) - 2;

            int temp = dx;
            dx = -dy;
            dy = temp;
            changes++;
        }

        col += dx;
        row += dy;
    }

    return result;
}

// метод вывода двумерного массива
// void Print2DArr(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int temp1 = i;
//         int temp2 = 0;
//         string str = " ";
//         Console.Write("[");
//         for (int j = 0; j < arr.GetLength(1) - 1; j++)
//         {
//             str = String.Format("{0:d2}", arr[i, j]);
//             Console.Write(str + ", ");
//             temp2 = j + 1;
//         }
//         str = String.Format("{0:d2}", arr[temp1, temp2]);
//         Console.WriteLine(str + "]");
//     }
// }


int[,] InitMatrix(int rows, int columns)
{ return new int[rows, columns]; }


int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}
