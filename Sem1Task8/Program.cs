//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введённое число
    int inputNumber = int.Parse(inputLine);

    //Число для старта цикла
    int startNumber = 2;

    //Выходное значение
    string outLine = string.Empty;

    //Делаем цикл, добавляем в строку вывода только чётные числа
    while (startNumber < inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber = startNumber + 2;
    }

    //Проверяем чётное ли введённое число
    if (inputNumber % 2 == 0)
    { outLine = outLine + inputNumber; }

    //Выводим данные в консоль
    Console.WriteLine(outLine);
}