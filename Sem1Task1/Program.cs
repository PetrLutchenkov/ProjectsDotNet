
//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if (num1Line != null && num2Line != null)
{
    //Парсим (переводим в целочисленные значения) введённые числа
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

   if (num1 == num2 * num2)
   {
    Console.WriteLine("Первое число квадрат второго!");
   }
   else
   {
    Console.WriteLine("Первое число не квадрат второго!");
   }
}