void TestSQRT(int i, int j)
{
    bool result = (i / j == j);
    if (result == true) Console.WriteLine(" Число " + i + " является квадратом числа " + j);
    else Console.WriteLine(" Число " + i + " не является квадратом числа " + j);
}

int number1 = int.Parse(Console.ReadLine() ?? "0");
int number2 = int.Parse(Console.ReadLine() ?? "0");

TestSQRT(number1, number2);
TestSQRT(number2, number1);