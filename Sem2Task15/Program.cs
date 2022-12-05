//Считываем данные с консоли
int number = int.Parse(Console.ReadLine() ?? "0");

//Проверяем число на соответствие дню недели
if (number < 8 && number != 0)
{
    if (number > 5)
    {
        //Выводим данные в консоль
        Console.WriteLine("да");
    }
    else
    {
        //Выводим данные в консоль
        Console.WriteLine("нет");
    }
}
else
{
    //Выводим данные в консоль
    Console.WriteLine("Цифра не соответствует дню недели");
}