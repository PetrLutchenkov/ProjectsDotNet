//Считываем данные с консоли
int number = int.Parse(Console.ReadLine() ?? "0");

//Проверяем,что число трёхзначное
if (number > 99 && number < 1000)
{
    //Получаем второе число
    int secondSign = number / 10 % 10;

    //Выводим данные в консоль
    Console.WriteLine(secondSign);
}
else
{
    //Выводим данные в консоль
    Console.WriteLine("Введите трёхзначное число!");
}