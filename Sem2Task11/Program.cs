System.Random numberSintezator = new System.Random(); // создаем экземпляр класса рандомайзер

int num = numberSintezator.Next(100, 1000); // получаем случайное число
Console.WriteLine(num);

int firstNum = num / 100; // получаем старший разряд числа
int secondNum = num % 10; // получаем младший разряд числа

int result = firstNum * 10 + secondNum;

Console.WriteLine(result);