// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg, int result)
{
    Console.WriteLine(msg + result);
}

int Akkerman(int m, int n) // Функция Аккермана
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int M = ReadData("Введите число m ");
int N = ReadData("Введите число n ");
PrintData("A(m,n) = ", Akkerman(M, N));