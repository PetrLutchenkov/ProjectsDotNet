// Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал

string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

string NameChoice(string str)
{
    string[] names = str.Split(",");
    string name = names[new Random().Next(0, names.Length)].Trim(); // Trim убирает пробелы
    return name;
}
string msg = ReadData("Введите имен через запятую: ");
PrintData("" + NameChoice(msg));