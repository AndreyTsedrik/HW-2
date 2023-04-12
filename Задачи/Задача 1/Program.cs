int random = new Random().Next(100, 999);
int number1 = random / 10;
int number2 = number1 % 10;

Console.WriteLine($"Случайное число {random}");
Console.WriteLine($"Вторая цифра {number2}");