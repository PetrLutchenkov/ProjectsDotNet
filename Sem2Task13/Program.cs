//Считываем данные с консоли
int number = int.Parse(Console.ReadLine() ?? "0");

//Проверяем имеет ли число третью цифру
if (number > 99)
{
    //Превращаем число в массив
    Char[] digits = number.ToString().ToCharArray();

    //Выводим третий элемент массива
    Console.WriteLine(digits[2]);
}
else
{
    //Выводим данные в консоль
    Console.WriteLine("Третьей цифры нет");
}