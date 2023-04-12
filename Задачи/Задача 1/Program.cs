// int random = new Random().Next(100, 999);
// int number1 = random / 10;
// int number2 = number1 % 10;

// Console.WriteLine($"Случайное число {random}");
// Console.WriteLine($"Вторая цифра {number2}");

System.Console.WriteLine("Введите трехзначное число ");
int number = 0;
while (!int.TryParse (Console.ReadLine(), out number)){System.Console.WriteLine("Это не число");}
if (number > 99 && number < 1000){
    int number1 = number / 10;
    int number2 = number1 % 10;
    Console.WriteLine($"Вторая цифра {number2}");
}
else{
    System.Console.WriteLine("Это не трехзначное число");
}