
//Считываем данные с консоли
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(Num1Line != null && Num2Line != null)
{
    //Парсим (переводим в целочисленные значения) введённые числа
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);

    //Находит произведение
    int outResult = num1*num2;

    //Выводим данные в консоль
    Console.WriteLine(outResult);
}
