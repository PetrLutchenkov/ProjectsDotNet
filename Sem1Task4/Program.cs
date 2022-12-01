//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (num1Line != null && num2Line != null && num3Line != null)
{
    //Парсим (переводим в целочисленные значения) введённые числа
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

    //Находим наибольшее из 1 и 2 чисел
    int max = Math.Max(num1, num2);

    //Выводим максимальное между наибольшим числом из первой пары чисел и 3м числом в консоль
    Console.WriteLine(Math.Max(max, num3));
}