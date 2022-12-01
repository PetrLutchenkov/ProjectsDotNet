//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{

    //Парсим введённое число
    int inputNumber = int.Parse(inputLine);

    int startNumber = inputNumber * (-1);

    //Выходное значение
    string outLine = string.Empty;

    while (startNumber < inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber++;
    }
    outLine = outLine + inputNumber;
    //Выводим данные в консоль
    Console.WriteLine(outLine);
}